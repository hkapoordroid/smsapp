using System;
using PropertyChanged;
using System.Collections.Generic;

namespace XFSMS.Models
{
	[AddINotifyPropertyChangedInterface]
	public class Contest
	{
		public string ImageUri { get; set; }
        public string Name { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }		
        public int DurationDays { get; set; }
        public bool AllowBidding { get; set; }


		public int CriteriaInstaFollower { get; set; }
		public int CriteriaFBFriends { get; set; }

        public List<User> Owner { get; set; }
        public List<string> GiveAwayImages { get; set; }
        public List<User> Members { get; set; }

		public Contest()
		{


		}
	}
}