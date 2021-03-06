﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class CountryList
    {
        public string IsoCode { get; set; }
        public string Name { get; set; }

        private List<CountryList> _countries = new List<CountryList>();

        public List<CountryList> Countries()
        {
            _countries.Add(new CountryList { Name = "Afghanistan", IsoCode = "/Flags/AF.png" });
            _countries.Add(new CountryList { Name = "Albania", IsoCode = "/Flags/AL.png" });
            _countries.Add(new CountryList { Name = "Algeria", IsoCode = "/Flags/DZ.png" });
            _countries.Add(new CountryList { Name = "Andorra", IsoCode = "/Flags/AD.png" });
            _countries.Add(new CountryList { Name = "Angola", IsoCode = "/Flags/AO.png" });
            _countries.Add(new CountryList { Name = "Antigua and Barbuda", IsoCode = "/Flags/AG.png" });
            _countries.Add(new CountryList { Name = "Argentina", IsoCode = "/Flags/AR.png" });
            _countries.Add(new CountryList { Name = "Armenia", IsoCode = "/Flags/AM.png" });
            _countries.Add(new CountryList { Name = "Australia", IsoCode = "/Flags/AU.png" });
            _countries.Add(new CountryList { Name = "Austria", IsoCode = "/Flags/AT.png" });
            _countries.Add(new CountryList { Name = "Azerbaijan", IsoCode = "/Flags/AZ.png" });
            _countries.Add(new CountryList { Name = "Bahamas", IsoCode = "/Flags/BS.png" });
            _countries.Add(new CountryList { Name = "Bahrain", IsoCode = "/Flags/BH.png" });
            _countries.Add(new CountryList { Name = "Bangladesh", IsoCode = "/Flags/BD.png" });
            _countries.Add(new CountryList { Name = "Barbados", IsoCode = "/Flags/BB.png" });
            _countries.Add(new CountryList { Name = "Belarus", IsoCode = "/Flags/BY.png" });
            _countries.Add(new CountryList { Name = "Belgium", IsoCode = "/Flags/BE.png" });
            _countries.Add(new CountryList { Name = "Belize", IsoCode = "/Flags/BZ.png" });
            _countries.Add(new CountryList { Name = "Benin", IsoCode = "/Flags/BJ.png" });
            _countries.Add(new CountryList { Name = "Bhutan", IsoCode = "/Flags/BT.png" });
            _countries.Add(new CountryList { Name = "Bolivia", IsoCode = "/Flags/BO.png" });
            _countries.Add(new CountryList { Name = "Bosnia and Herzegovina", IsoCode = "/Flags/BA.png" });
            _countries.Add(new CountryList { Name = "Botswana", IsoCode = "/Flags/BW.png" });
            _countries.Add(new CountryList { Name = "Brazil", IsoCode = "/Flags/BR.png" });
            _countries.Add(new CountryList { Name = "Brunei Darussalam", IsoCode = "/Flags/BN.png" });
            _countries.Add(new CountryList { Name = "Bulgaria", IsoCode = "/Flags/BG.png" });
            _countries.Add(new CountryList { Name = "Burkina Faso", IsoCode = "/Flags/BF.png" });
            _countries.Add(new CountryList { Name = "Burundi", IsoCode = "/Flags/BI.png" });
            _countries.Add(new CountryList { Name = "Cambodia", IsoCode = "/Flags/KH.png" });
            _countries.Add(new CountryList { Name = "Cameroon", IsoCode = "/Flags/CM.png" });
            _countries.Add(new CountryList { Name = "Canada", IsoCode = "/Flags/CA.png" });
            _countries.Add(new CountryList { Name = "Cape Verde", IsoCode = "/Flags/CV.png" });
            _countries.Add(new CountryList { Name = "Central African Republic", IsoCode = "/Flags/CF.png" });
            _countries.Add(new CountryList { Name = "Chad", IsoCode = "/Flags/TD.png" });
            _countries.Add(new CountryList { Name = "Chile", IsoCode = "/Flags/CL.png" });
            _countries.Add(new CountryList { Name = "China", IsoCode = "/Flags/CN.png" });
            _countries.Add(new CountryList { Name = "Colombia", IsoCode = "/Flags/CO.png" });
            _countries.Add(new CountryList { Name = "Comoros", IsoCode = "/Flags/KM.png" });
            _countries.Add(new CountryList { Name = "Congo", IsoCode = "/Flags/CG.png" });
            _countries.Add(new CountryList { Name = "Congo, the Democratic Republic of the", IsoCode = "/Flags/CD.png" });
            _countries.Add(new CountryList { Name = "Costa Rica", IsoCode = "/Flags/CR.png" });
            _countries.Add(new CountryList { Name = "CÃ´te d'Ivoire", IsoCode = "/Flags/CI.png" });
            _countries.Add(new CountryList { Name = "Croatia", IsoCode = "/Flags/HR.png" });
            _countries.Add(new CountryList { Name = "Cuba", IsoCode = "/Flags/CU.png" });
            _countries.Add(new CountryList { Name = "Cyprus", IsoCode = "/Flags/CY.png" });
            _countries.Add(new CountryList { Name = "Czech Republic", IsoCode = "/Flags/CZ.png" });
            _countries.Add(new CountryList { Name = "Denmark", IsoCode = "/Flags/DK.png" });
            _countries.Add(new CountryList { Name = "Djibouti", IsoCode = "/Flags/DJ.png" });
            _countries.Add(new CountryList { Name = "Dominica", IsoCode = "/Flags/DM.png" });
            _countries.Add(new CountryList { Name = "Dominican Republic", IsoCode = "/Flags/DO.png" });
            _countries.Add(new CountryList { Name = "Ecuador", IsoCode = "/Flags/EC.png" });
            _countries.Add(new CountryList { Name = "Egypt", IsoCode = "/Flags/EG.png" });
            _countries.Add(new CountryList { Name = "El Salvador", IsoCode = "/Flags/SV.png" });
            _countries.Add(new CountryList { Name = "Equatorial Guinea", IsoCode = "/Flags/GQ.png" });
            _countries.Add(new CountryList { Name = "Eritrea", IsoCode = "/Flags/ER.png" });
            _countries.Add(new CountryList { Name = "Estonia", IsoCode = "/Flags/EE.png" });
            _countries.Add(new CountryList { Name = "Ethiopia", IsoCode = "/Flags/ET.png" });
            _countries.Add(new CountryList { Name = "Fiji", IsoCode = "/Flags/FJ.png" });
            _countries.Add(new CountryList { Name = "Finland", IsoCode = "/Flags/FI.png" });
            _countries.Add(new CountryList { Name = "France", IsoCode = "/Flags/FR.png" });
            _countries.Add(new CountryList { Name = "Gabon", IsoCode = "/Flags/GA.png" });
            _countries.Add(new CountryList { Name = "Gambia", IsoCode = "/Flags/GM.png" });
            _countries.Add(new CountryList { Name = "Georgia", IsoCode = "/Flags/GE.png" });
            _countries.Add(new CountryList { Name = "Germany", IsoCode = "/Flags/DE.png" });
            _countries.Add(new CountryList { Name = "Ghana", IsoCode = "/Flags/GH.png" });
            _countries.Add(new CountryList { Name = "Greece", IsoCode = "/Flags/GR.png" });
            _countries.Add(new CountryList { Name = "Grenada", IsoCode = "/Flags/GD.png" });
            _countries.Add(new CountryList { Name = "Guatemala", IsoCode = "/Flags/GT.png" });
            _countries.Add(new CountryList { Name = "Guinea", IsoCode = "/Flags/GN.png" });
            _countries.Add(new CountryList { Name = "Guinea-Bissau", IsoCode = "/Flags/GW.png" });
            _countries.Add(new CountryList { Name = "Guyana", IsoCode = "/Flags/GY.png" });
            _countries.Add(new CountryList { Name = "Haiti", IsoCode = "/Flags/HT.png" });
            _countries.Add(new CountryList { Name = "Honduras", IsoCode = "/Flags/HN.png" });
            _countries.Add(new CountryList { Name = "Hong Kong", IsoCode = "/Flags/HK.png" });
            _countries.Add(new CountryList { Name = "Hungary", IsoCode = "/Flags/HU.png" });
            _countries.Add(new CountryList { Name = "Iceland", IsoCode = "/Flags/IS.png" });
            _countries.Add(new CountryList { Name = "India", IsoCode = "/Flags/IN.png" });
            _countries.Add(new CountryList { Name = "Indonesia", IsoCode = "/Flags/ID.png" });
            _countries.Add(new CountryList { Name = "Iran, Islamic Republic of", IsoCode = "/Flags/IR.png" });
            _countries.Add(new CountryList { Name = "Iraq", IsoCode = "/Flags/IQ.png" });
            _countries.Add(new CountryList { Name = "Ireland", IsoCode = "/Flags/IE.png" });
            _countries.Add(new CountryList { Name = "Israel", IsoCode = "/Flags/IL.png" });
            _countries.Add(new CountryList { Name = "Italy", IsoCode = "/Flags/IT.png" });
            _countries.Add(new CountryList { Name = "Jamaica", IsoCode = "/Flags/JM.png" });
            _countries.Add(new CountryList { Name = "Japan", IsoCode = "/Flags/JP.png" });
            _countries.Add(new CountryList { Name = "Jordan", IsoCode = "/Flags/JO.png" });
            _countries.Add(new CountryList { Name = "Kazakhstan", IsoCode = "/Flags/KZ.png" });
            _countries.Add(new CountryList { Name = "Kenya", IsoCode = "/Flags/KE.png" });
            _countries.Add(new CountryList { Name = "Kiribati", IsoCode = "/Flags/KI.png" });
            _countries.Add(new CountryList { Name = "Kosovo", IsoCode = "/Flags/RK.png" });
            _countries.Add(new CountryList { Name = "Kuwait", IsoCode = "/Flags/KW.png" });
            _countries.Add(new CountryList { Name = "Kyrgyzstan", IsoCode = "/Flags/KG.png" });
            _countries.Add(new CountryList { Name = "Lao PDR", IsoCode = "/Flags/LA.png" });
            _countries.Add(new CountryList { Name = "Latvia", IsoCode = "/Flags/LV.png" });
            _countries.Add(new CountryList { Name = "Lebanon", IsoCode = "/Flags/LB.png" });
            _countries.Add(new CountryList { Name = "Lesotho", IsoCode = "/Flags/LS.png" });
            _countries.Add(new CountryList { Name = "Liberia", IsoCode = "/Flags/LR.png" });
            _countries.Add(new CountryList { Name = "Libya", IsoCode = "/Flags/LY.png" });
            _countries.Add(new CountryList { Name = "Liechtenstein", IsoCode = "/Flags/LI.png" });
            _countries.Add(new CountryList { Name = "Lithuania", IsoCode = "/Flags/LT.png" });
            _countries.Add(new CountryList { Name = "Luxembourg", IsoCode = "/Flags/LU.png" });
            _countries.Add(new CountryList { Name = "Macao", IsoCode = "/Flags/MO.png" });
            _countries.Add(new CountryList { Name = "Macedonia, Republic of", IsoCode = "/Flags/MK.png" });
            _countries.Add(new CountryList { Name = "Madagascar", IsoCode = "/Flags/MG.png" });
            _countries.Add(new CountryList { Name = "Malawi", IsoCode = "/Flags/MW.png" });
            _countries.Add(new CountryList { Name = "Malaysia", IsoCode = "/Flags/MY.png" });
            _countries.Add(new CountryList { Name = "Maldives", IsoCode = "/Flags/MV.png" });
            _countries.Add(new CountryList { Name = "Mali", IsoCode = "/Flags/ML.png" });
            _countries.Add(new CountryList { Name = "Malta", IsoCode = "/Flags/MT.png" });
            _countries.Add(new CountryList { Name = "Marshall Islands", IsoCode = "/Flags/MH.png" });
            _countries.Add(new CountryList { Name = "Mauritania", IsoCode = "/Flags/MR.png" });
            _countries.Add(new CountryList { Name = "Mauritius", IsoCode = "/Flags/MU.png" });
            _countries.Add(new CountryList { Name = "Mexico", IsoCode = "/Flags/MX.png" });
            _countries.Add(new CountryList { Name = "Micronesia, Federated States of", IsoCode = "/Flags/FM.png" });
            _countries.Add(new CountryList { Name = "Moldova, Republic of", IsoCode = "/Flags/MD.png" });
            _countries.Add(new CountryList { Name = "Monaco", IsoCode = "/Flags/MC.png" });
            _countries.Add(new CountryList { Name = "Mongolia", IsoCode = "/Flags/MN.png" });
            _countries.Add(new CountryList { Name = "Montenegro", IsoCode = "/Flags/ME.png" });
            _countries.Add(new CountryList { Name = "Morocco", IsoCode = "/Flags/MA.png" });
            _countries.Add(new CountryList { Name = "Mozambique", IsoCode = "/Flags/MZ.png" });
            _countries.Add(new CountryList { Name = "Myanmar", IsoCode = "/Flags/MM.png" });
            _countries.Add(new CountryList { Name = "Namibia", IsoCode = "/Flags/NA.png" });
            _countries.Add(new CountryList { Name = "Nauru", IsoCode = "/Flags/NR.png" });
            _countries.Add(new CountryList { Name = "Nepal", IsoCode = "/Flags/NP.png" });
            _countries.Add(new CountryList { Name = "Netherlands", IsoCode = "/Flags/NL.png" });
            _countries.Add(new CountryList { Name = "New Zealand", IsoCode = "/Flags/NZ.png" });
            _countries.Add(new CountryList { Name = "Nicaragua", IsoCode = "/Flags/NI.png" });
            _countries.Add(new CountryList { Name = "Niger", IsoCode = "/Flags/NE.png" });
            _countries.Add(new CountryList { Name = "Nigeria", IsoCode = "/Flags/NG.png" });
            _countries.Add(new CountryList { Name = "North Korea", IsoCode = "/Flags/KP.png" });
            _countries.Add(new CountryList { Name = "Norway", IsoCode = "/Flags/NO.png" });
            _countries.Add(new CountryList { Name = "Oman", IsoCode = "/Flags/OM.png" });
            _countries.Add(new CountryList { Name = "Pakistan", IsoCode = "/Flags/PK.png" });
            _countries.Add(new CountryList { Name = "Palau", IsoCode = "/Flags/PW.png" });
            _countries.Add(new CountryList { Name = "Palestinian Territory, Occupied", IsoCode = "/Flags/PS.png" });
            _countries.Add(new CountryList { Name = "Panama", IsoCode = "/Flags/PA.png" });
            _countries.Add(new CountryList { Name = "Papua New Guinea", IsoCode = "/Flags/PG.png" });
            _countries.Add(new CountryList { Name = "Paraguay", IsoCode = "/Flags/PY.png" });
            _countries.Add(new CountryList { Name = "Peru", IsoCode = "/Flags/PE.png" });
            _countries.Add(new CountryList { Name = "Philippines", IsoCode = "/Flags/PH.png" });
            _countries.Add(new CountryList { Name = "Poland", IsoCode = "/Flags/PL.png" });
            _countries.Add(new CountryList { Name = "Portugal", IsoCode = "/Flags/PT.png" });
            _countries.Add(new CountryList { Name = "Qatar", IsoCode = "/Flags/QA.png" });
            _countries.Add(new CountryList { Name = "Romania", IsoCode = "/Flags/RO.png" });
            _countries.Add(new CountryList { Name = "Russian Federation", IsoCode = "/Flags/RU.png" });
            _countries.Add(new CountryList { Name = "Rwanda", IsoCode = "/Flags/RW.png" });
            _countries.Add(new CountryList { Name = "Saint Kitts and Nevis", IsoCode = "/Flags/KN.png" });
            _countries.Add(new CountryList { Name = "Saint Lucia", IsoCode = "/Flags/LC.png" });
            _countries.Add(new CountryList { Name = "Samoa", IsoCode = "/Flags/WS.png" });
            _countries.Add(new CountryList { Name = "San Marino", IsoCode = "/Flags/SM.png" });
            _countries.Add(new CountryList { Name = "Sao Tome and Principe", IsoCode = "/Flags/ST.png" });
            _countries.Add(new CountryList { Name = "Saudi Arabia", IsoCode = "/Flags/SA.png" });
            _countries.Add(new CountryList { Name = "Senegal", IsoCode = "/Flags/SN.png" });
            _countries.Add(new CountryList { Name = "Serbia", IsoCode = "/Flags/RS.png" });
            _countries.Add(new CountryList { Name = "Seychelles", IsoCode = "/Flags/SC.png" });
            _countries.Add(new CountryList { Name = "Sierra Leone", IsoCode = "/Flags/SL.png" });
            _countries.Add(new CountryList { Name = "Singapore", IsoCode = "/Flags/SG.png" });
            _countries.Add(new CountryList { Name = "Slovakia", IsoCode = "/Flags/SK.png" });
            _countries.Add(new CountryList { Name = "Slovenia", IsoCode = "/Flags/SI.png" });
            _countries.Add(new CountryList { Name = "Solomon Islands", IsoCode = "/Flags/SB.png" });
            _countries.Add(new CountryList { Name = "Somalia", IsoCode = "/Flags/SO.png" });
            _countries.Add(new CountryList { Name = "South Africa", IsoCode = "/Flags/ZA.png" });
            _countries.Add(new CountryList { Name = "South Korea", IsoCode = "/Flags/KR.png" });
            _countries.Add(new CountryList { Name = "South Sudan", IsoCode = "/Flags/SS.png" });
            _countries.Add(new CountryList { Name = "Spain", IsoCode = "/Flags/ES.png" });
            _countries.Add(new CountryList { Name = "Sri Lanka", IsoCode = "/Flags/LK.png" });
            _countries.Add(new CountryList { Name = "Saint Vincent and the Grenadines", IsoCode = "/Flags/VC.png" });
            _countries.Add(new CountryList { Name = "Sudan", IsoCode = "/Flags/SD.png" });
            _countries.Add(new CountryList { Name = "Suriname", IsoCode = "/Flags/SR.png" });
            _countries.Add(new CountryList { Name = "Swaziland", IsoCode = "/Flags/SZ.png" });
            _countries.Add(new CountryList { Name = "Sweden", IsoCode = "/Flags/SE.png" });
            _countries.Add(new CountryList { Name = "Switzerland", IsoCode = "/Flags/CH.png" });
            _countries.Add(new CountryList { Name = "Syrian Arab Republic", IsoCode = "/Flags/SY.png" });
            _countries.Add(new CountryList { Name = "Taiwan, Province of China", IsoCode = "/Flags/TW.png" });
            _countries.Add(new CountryList { Name = "Tajikistan", IsoCode = "/Flags/TJ.png" });
            _countries.Add(new CountryList { Name = "Tanzania, United Republic of", IsoCode = "/Flags/TZ.png" });
            _countries.Add(new CountryList { Name = "Thailand", IsoCode = "/Flags/TH.png" });
            _countries.Add(new CountryList { Name = "Timor-Leste", IsoCode = "/Flags/TL.png" });
            _countries.Add(new CountryList { Name = "Togo", IsoCode = "/Flags/TG.png" });
            _countries.Add(new CountryList { Name = "Tonga", IsoCode = "/Flags/TO.png" });
            _countries.Add(new CountryList { Name = "Trinidad and Tobago", IsoCode = "/Flags/TT.png" });
            _countries.Add(new CountryList { Name = "Tunisia", IsoCode = "/Flags/TN.png" });
            _countries.Add(new CountryList { Name = "Turkey", IsoCode = "/Flags/TR.png" });
            _countries.Add(new CountryList { Name = "Turkmenistan", IsoCode = "/Flags/TM.png" });
            _countries.Add(new CountryList { Name = "Tuvalu", IsoCode = "/Flags/TV.png" });
            _countries.Add(new CountryList { Name = "Uganda", IsoCode = "/Flags/UG.png" });
            _countries.Add(new CountryList { Name = "Ukraine", IsoCode = "/Flags/UA.png" });
            _countries.Add(new CountryList { Name = "United Arab Emirates", IsoCode = "/Flags/AE.png" });
            _countries.Add(new CountryList { Name = "United Kingdom", IsoCode = "/Flags/UK.png" });
            _countries.Add(new CountryList { Name = "United States", IsoCode = "/Flags/US.png" });
            _countries.Add(new CountryList { Name = "Uruguay", IsoCode = "/Flags/UY.png" });
            _countries.Add(new CountryList { Name = "Uzbekistan", IsoCode = "/Flags/UZ.png" });
            _countries.Add(new CountryList { Name = "Vanuatu", IsoCode = "/Flags/VU.png" });
            _countries.Add(new CountryList { Name = "Holy See (Vatican City State)", IsoCode = "/Flags/VA.png" });
            _countries.Add(new CountryList { Name = "Venezuela, Bolivarian Republic of", IsoCode = "/Flags/VE.png" });
            _countries.Add(new CountryList { Name = "Viet Nam", IsoCode = "/Flags/VN.png" });
            _countries.Add(new CountryList { Name = "Yemen", IsoCode = "/Flags/YE.png" });
            _countries.Add(new CountryList { Name = "Zambia", IsoCode = "/Flags/ZM.png" });
            _countries.Add(new CountryList { Name = "Zimbabwe", IsoCode = "/Flags/ZW.png" });

            return _countries;
        }
    }
}
