﻿using System;
using System.Collections.Generic;
using PropertyChanged;

namespace XFSMS.Models
{
    [AddINotifyPropertyChangedInterface]
    public class PlatformPostInfo
    {
        public string ImageURL { get; set; }
		public int CountLikes { get; set; }
		public int CountComments { get; set; }
		public int CountShares { get; set; }



		public Constants.Platforms PlatformType { get; set; }
        /*
		public List<InstaUser> ShareLikes{ get; set; }
        public List<InstaUser> ShareComments { get; set; }
        public List<InstaUser> ShareUsers { get; set; }
        */
        public PlatformPostInfo()
        {
            
        }
    }
}
