﻿﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using PropertyChanged;

namespace XFSMS.Models
{
    [AddINotifyPropertyChangedInterface]
    public class AdPost :BasePost
    {
        private int x = 0;
        public int NetFollowersCount { get; set; }

        public Constants.AdStatus Status { get; set; }

        public Compensation Compensation { get; set; }

        public ShareCriteria ShareCriteria { get; set; }

        public List<User> Owners { get; set; }

        public List<User> Members { get; set; }

        public List<User> Interested { get; set; }

        public List<User> Guest { get; set; }

        public Chat Chat { get; set; }


		public string Offering { get; set; }

        public AdPost()
        {
            //setting default
            Status = Constants.AdStatus.Posted;
            Compensation = new Compensation();
            ShareCriteria = new ShareCriteria();
            Offering = "10";
            Owners = new List<User>();
            Owners.Add(new User());
			Members = new List<User>();
			Members.Add(new User());
            Members.Add(new User());
			Guest = new List<User>();
			Guest.Add(new User());
			Guest.Add(new User());

            foreach(User u in Owners)
            {
                foreach(PlatformUser p in u.SocialProfiles)
                {
                    x = x + p.FollowersCount;
                }

            }

            NetFollowersCount = x;
        }
    }
}

