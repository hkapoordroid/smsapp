using System;
using PropertyChanged;


namespace XFSMS.Models
{
    [AddINotifyPropertyChangedInterface]
    public class ContestSettings
    {
		public string Name { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime StartDate { get; set; }

		public string ImageUri { get; set; }


		public int CriteriaInstaFollower { get; set; }
		public int CriteriaFBFriends { get; set; }

        public ContestSettings()
        {


        }
    }
}
