﻿using System;
using PropertyChanged;
using Xamarin.Forms;

namespace XFSMS.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Location 
    {
        public string CityName{ get; set; }
        public string CountryName{ get; set; }
        public string StreetName{ get; set; }
        public string ZipCode{ get; set; }

        public Location()
        {
            CityName = "carmel";
            CountryName = "USA";
            StreetName = "5883 sandalwood";
            ZipCode = "46033";
        }
    }
}

