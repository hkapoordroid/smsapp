using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using XFSMS.Models;
namespace XFSMS.Services
{
    public interface IDataService
    {

        //Ads
        List<User> GetAdMembers(string PostID);
        List<AdPost> GetAdsByUser(string UserID);
        ObservableCollection<AdPost> GetAdsFeatured();
        bool PostAd(AdPost Ad);
        bool UpdateAd(AdPost Ad);
        bool RemoveAd(AdPost Ad);

        //Events
        List<User> GetEventMembers(string PostID);
        List<EventPost> GetEventsByUser(string UserID); 
		List<EventPost> GetEventsFeatured();
        bool PostEvent(EventPost Event);
        bool UpdateEvent(AdPost Ad);
        bool RemoveEvent(AdPost Ad);

        //User
        List<User> GetFriends(string UserID);
        List<User> GetTeams(string UserID);
        List<Constants.Platforms> GetPlatforms(string UserID);
        Location GetLocation(string UserID);
        bool AddUser(User user);
        bool UpdateUser(User user);



    }
}
