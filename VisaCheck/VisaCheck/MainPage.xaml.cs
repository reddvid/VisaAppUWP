using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VisaCheck
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<Person> people = new List<Person>
            {
                new Person("Abigail", new DateTime(1975, 1, 15), Color.Aqua),
                new Person("Bob", new DateTime(1976, 2, 20), Color.Black),
                // ...etc.,...
                new Person("Yvonne", new DateTime(1987, 1, 10), Color.Purple),
                new Person("Zachary", new DateTime(1988, 2, 5), Color.Red)
            };

            listView.ItemsSource = people;
            listView.ItemTemplate = new DataTemplate(() =>
               {
                   // Create views with bindings for displaying each property.
                   Label nameLabel = new Label();
                   nameLabel.SetBinding(Label.TextProperty, "Name");

                   Label birthdayLabel = new Label();
                   birthdayLabel.SetBinding(Label.TextProperty,
                       new Binding("Birthday", BindingMode.OneWay,
                           null, null, "Born {0:d}"));

                   BoxView boxView = new BoxView();
                   boxView.SetBinding(BoxView.ColorProperty, "FavoriteColor");

                   // Return an assembled ViewCell.
                   return new ViewCell
                   {
                       View = new StackLayout
                       {
                           Padding = new Thickness(0, 5),
                           Orientation = StackOrientation.Horizontal,
                           Children =
                           {
                                boxView,
                                new StackLayout
                                {
                                    VerticalOptions = LayoutOptions.Center,
                                    Spacing = 0,
                                    Children =
                                    {
                                        nameLabel,
                                        birthdayLabel
                                    }
                                }
                           }
                       }
                   };
               });
        }

        public class Person
        {
            public Person(string name, DateTime birthday, Color favoriteColor)
            {
                this.Name = name;
                this.Birthday = birthday;
                this.FavoriteColor = favoriteColor;
            }

            public string Name { private set; get; }

            public DateTime Birthday { private set; get; }

            public Color FavoriteColor { private set; get; }
        };

    }
}
