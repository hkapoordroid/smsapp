﻿using System;

using PropertyChanged;
using System.Collections.Generic;
namespace XFSMS.Models
{
    [AddINotifyPropertyChangedInterface]
    public class ContestTile
    {
        public ContestTile()
        {
            ID = Guid.NewGuid().ToString();
            Title = "GiveAway";
            _InstaLikes = 100;
            _InstaComments = 32;
            _InstaFollowers = 97;
            EndDate = DateTime.Today;


        }

        public string ID { get; set; }
		public string ImageUri { get; set; }
		public string Title { get; set; }
        public int _InstaLikes { get; set; }
		public int _InstaComments { get; set; }
		public int _InstaFollowers { get; set; }
		public DateTime EndDate { get; set; }

    }
}
