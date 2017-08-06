using System;
using System.Collections.Generic;
using PropertyChanged;
namespace XFSMS.Models
{
    [AddINotifyPropertyChangedInterface]
    public class User
    {
        public string Userid { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public Location Location{ get; set; }
        public string ImageUri { get; set; }

        public List<AdPost> UserAds;
		public List<EventPost> UserEvents;
        public List<Chat> Chats;

        public List<PlatformUser> SocialProfiles{ get; set; }

        public User()
        {
            Userid = Guid.NewGuid().ToString();
                            Name = Userid;
            Email = "email@gmail.com";
            Location = new Location();
            UserAds = new List<AdPost>();
            UserEvents = new List<EventPost>();

            SocialProfiles = new List<PlatformUser>();
            SocialProfiles.Add(new PlatformUser());
        }


    }
}
