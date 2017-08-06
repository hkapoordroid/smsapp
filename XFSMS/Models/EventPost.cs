using System;
using System.Collections.Generic;
using PropertyChanged;
using Xamarin.Forms;

namespace XFSMS.Models
{
    [AddINotifyPropertyChangedInterface]
    public class EventPost : BasePost
    {
        public Constants.EventStatus _Status { get; set; }

        public List<Constants.Platforms> _OnPlatforms { get; set; }

        public List<User> _Owners { get; set; }

        public List<User> _Members { get; set; }

        public List<Constants.Platforms> _PlatformsStats { get; set; }

        public Chat _Chat { get; set; }

        public EventPost()
        {
			//setting default
			_Status = Constants.EventStatus.Running;
            _OnPlatforms = new List<Constants.Platforms>();
            _OnPlatforms.Add(Models.Constants.Platforms.instagram);
            _OnPlatforms.Add(Models.Constants.Platforms.facebook);
			_Owners = new List<User>();
			_Owners.Add(new User());
			_Members = new List<User>();
			_Members.Add(new User());
			_Members.Add(new User());

        }
    }
}

