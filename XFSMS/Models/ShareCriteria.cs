using System;
using System.Collections.Generic;
using PropertyChanged;

namespace XFSMS.Models
{
    [AddINotifyPropertyChangedInterface]
    public class ShareCriteria
    {
        //Share based on following Criteria
        public int CriteriaInstaFollower { get; set; }
		public int CriteriaFBFriends{ get; set; }
		public int CriteriaBusiness{ get; set; }
        public List<Location> Locations{ get; set; }


        public ShareCriteria()
        {
            CriteriaInstaFollower = 50;
            CriteriaFBFriends = 50;
            CriteriaBusiness = 30;
            Locations = new List<Location>();

        }
    }
}
