using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using XFSMS.Models;

namespace XFSMS.Services
{
    public class DataService:IDataService
    {
        public DataService()
        {
        }

        public bool AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAdMembers(string PostID)
        {
            throw new NotImplementedException();
        }

        public List<AdPost> GetAdsByUser(string UserID)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<AdPost> GetAdsFeatured()
        {
			ObservableCollection<AdPost> ret = new ObservableCollection<AdPost>();
			for (int i = 0; i <= 5; i++)
			{
				ret.Add(new AdPost());
			}
			return ret;
        }

        public List<User> GetEventMembers(string PostID)
        {
            throw new NotImplementedException();
        }

        public List<EventPost> GetEventsByUser(string UserID)
        {
            throw new NotImplementedException();
        }

        public List<EventPost> GetEventsFeatured()
        {
            throw new NotImplementedException();
        }

        public List<User> GetFriends(string UserID)
        {
            throw new NotImplementedException();
        }

        public Location GetLocation(string UserID)
        {
            throw new NotImplementedException();
        }

        public List<Constants.Platforms> GetPlatforms(string UserID)
        {
            throw new NotImplementedException();
        }

        public List<User> GetTeams(string UserID)
        {
            throw new NotImplementedException();
        }

        public bool PostAd(AdPost Ad)
        {
            throw new NotImplementedException();
        }

        public bool PostEvent(EventPost Event)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAd(AdPost Ad)
        {
            throw new NotImplementedException();
        }

        public bool RemoveEvent(AdPost Ad)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAd(AdPost Ad)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEvent(AdPost Ad)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

    }
}
