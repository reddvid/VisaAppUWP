using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.System.UserProfile;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PassportsUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var countries = new CountryList().Countries();
            lvCountries.ItemsSource = countries;
            cboxFrom1.ItemsSource =
                cboxFrom2.ItemsSource =
                cboxFrom3.ItemsSource =
                cboxFrom4.ItemsSource =
                cboxFrom5.ItemsSource = countries;

            var region = GetDeviceRegion();

            cboxFrom1.Text = countries.Where(x => x.Name == region).FirstOrDefault().Name;
        }

        private string GetDeviceRegion()
        {
            // Obtain the user's home geographic region.
            var region = GlobalizationPreferences.HomeGeographicRegion;
            var geographicRegion = new Windows.Globalization.GeographicRegion().DisplayName;

            Debug.WriteLine($"Region: { region } \nGeographic Region: { geographicRegion }");
            return geographicRegion;
        }

        private void cboxFrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            ReadCsv(cb.Tag as string);
        }

        private void ReadCsv(string t)
        {
            // StorageFile sampleFile = await StorageFile.GetFileFromPathAsync("ms-appx:///index.csv");
            FileInfo myFile = new FileInfo("index.csv");
            var countries = new CountryList().Countries();
            var cb = new AutoSuggestBox();
            var lv = new ListView();

            if (t == "1")
            {
                cb = cboxFrom1;
                lv = lvFrom1;
            }
            else if (t == "2")
            {
                cb = cboxFrom2;
                lv = lvFrom2;
            }
            else if (t == "3")
            {
                cb = cboxFrom3;
                lv = lvFrom3;
            }
            else if (t == "4")
            {
                cb = cboxFrom4;
                lv = lvFrom4;
            }
            else if (t == "5")
            {
                cb = cboxFrom5;
                lv = lvFrom5;
            }

            // Open Excel File (Roaming)
            if (myFile != null && cb != null && lv != null)
            {
                Chilkat.Csv csv = new Chilkat.Csv();
                csv.HasColumnNames = false;

                bool success;
                success = csv.LoadFile(myFile.FullName);
                if (success != true)
                {
                    return;
                }

                Debug.WriteLine($"CSV success");

                var results = new List<string>();
                int row = countries.IndexOf(countries.Where(x => x.Name == cb.Text).FirstOrDefault()) + 1;
                int n = csv.NumColumns;
                for (int col = 1; col < n; col++)
                {
                    results.Add(ConvertToDescriptiveText(csv.GetCell(row, col)));
                }

                lv.ItemsSource = results;
                lv.Header = CountVisaFreeCountries(results);
            }
        }

        private string CountVisaFreeCountries(List<string> results)
        {
            int x = 0;
            foreach (var v in results)
            {
                if (v == "Visa-free" || v == "Visa on arrival")
                {
                    x++;
                }
            }

            return $" { x } Visa-free countries";
        }

        private string ConvertToDescriptiveText(string x)
        {
            if (x == "0")
                return "Visa required";
            else if (x == "1")
                return "Visa on arrival";
            else if (x == "2")
                return "e-Visa";
            else if (x == "3")
                return "Visa-free";
            else
                return string.Empty;

            // `3` means visa-free travel
            // `2` means eTA is required (which is essentially visa free)
            // `1` means visa can be obtained on arrival(which Passport Index considers visa - free)
            // `0` means visa is required
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Width >= 800 && e.NewSize.Width <= 1200)
            {
                // 3 Columns
                gMain1.Width = gMain2.Width = gMx1.Width = gMx2.Width = new GridLength(1, GridUnitType.Star);
                gEx1.Width = gEx2.Width = gFx1.Width = gFx2.Width = new GridLength(0, GridUnitType.Star);
            }
            else if (e.NewSize.Width < 800)
            {
                // 1 Column
                gEx1.Width = gEx2.Width = gFx1.Width = gFx2.Width = gMain1.Width = gMain2.Width = gMx1.Width = gMx2.Width = new GridLength(0, GridUnitType.Star);
            }
            else
            {
                // Show all
                gEx1.Width = gEx2.Width = gFx1.Width = gFx2.Width = gMain1.Width = gMain2.Width = gMx1.Width = gMx2.Width = new GridLength(1, GridUnitType.Star);
            }
        }

        private void lv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int x = (sender as ListView).SelectedIndex;
            UnifySelection(x);
        }

        private void UnifySelection(int x)
        {
            if (lvCountries.Items.Count != 0)
                lvCountries.SelectedIndex = x;

            if (lvFrom1.Items.Count != 0)
                lvFrom1.SelectedIndex = x;

            if (lvFrom2.Items.Count != 0)
                lvFrom2.SelectedIndex = x;

            if (lvFrom3.Items.Count != 0)
                lvFrom3.SelectedIndex = x;

            if (lvFrom4.Items.Count != 0)
                lvFrom4.SelectedIndex = x;

            if (lvFrom5.Items.Count != 0)
                lvFrom5.SelectedIndex = x;
        }

        private void lv_LayoutUpdated(object sender, object e)
        {
            try
            {
                int x = (sender as ListView).SelectedIndex;
                UnifySelection(x);
            }
            catch { }
        }

        private void sBoxFrom_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                //Set the ItemsSource to be your filtered dataset
                if (sender.Text.Length > 2)
                {
                    sender.ItemsSource = new CountryList().Countries().Where(x => x.Name.ToLower().Contains(sender.Text.ToLower()));
                }
                else
                {
                    sender.ItemsSource = new CountryList().Countries();
                }
            }
            else if (args.Reason == AutoSuggestionBoxTextChangeReason.ProgrammaticChange)
            {
               var cb = sender as AutoSuggestBox;
                ReadCsv(cb.Tag as string);
            }

            //var cb = sender as AutoSuggestBox;

            ////if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            ////    ReadCsv(cb.Tag as string);
            ////else if (args.Reason == AutoSuggestionBoxTextChangeReason.SuggestionChosen)
            //    ReadCsv(cb.Tag as string);
        }

        private void sBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var cb = sender as AutoSuggestBox;

            // cb.IsSuggestionListOpen = true;

            //if (string.IsNullOrEmpty(cb.Text))
            //{
                cb.ItemsSource = new CountryList().Countries();
            //}
            //else
            //{
            //    cb.ItemsSource = new CountryList().Countries().Where(x => x.Name.ToLower().Contains(cb.Text.ToLower()));
            //}
        }

        private void cboxFrom_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            sender.Text = (args.SelectedItem as CountryList).Name;

            var cb = sender as AutoSuggestBox;
            ReadCsv(cb.Tag as string);

            sender.Focus(FocusState.Unfocused);
        }

        private void cboxFrom1_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (args.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
                sender.Text = (args.ChosenSuggestion as CountryList).Name;

                var cb = sender as AutoSuggestBox;
                ReadCsv(cb.Tag as string);
            }
            else
            {
                // Use args.QueryText to determine what to do.
               
                    sender.Text = new CountryList().Countries().Where(x => x.Name.ToLower().Contains(args.QueryText.ToLower())).First().Name;
               
            }
        }
    }
}
