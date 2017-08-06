﻿using System;
using System.Collections.Generic;
using PropertyChanged;

namespace XFSMS.Models
{
    [AddINotifyPropertyChangedInterface]
    public class PlatformUser
    {
        public string Name { get; set; }
        public string Caption { get; set; }
        public string ImageURL { get; set; }
        public string InstaHandle { get; set; }

		public int FollowersCount { get; set; }

        public List<PlatformUser> Followers { get; set; }
        public List<Location> ReachLocation { get; set; }
        public List<Location> ReachSex { get; set; }

		public Constants.Platforms PlatformType ;

        public PlatformUser()
        {
            Name = "instauser";
            Caption = "instacaption";
            InstaHandle = "handle";
            FollowersCount = 8000;

        }
    }
}
