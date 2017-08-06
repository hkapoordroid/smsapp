using System;
using FreshMvvm;
using Xamarin.Forms;
using PropertyChanged;
using System.Collections.Generic;

namespace XFSMS.Pages
{
	[AddINotifyPropertyChangedInterface]
	public class AdPageCard 
	{


		public Models.Constants.ServiceTypes ServiceTypes { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public string CompensationAccept { get; set; }

		public string CompensationOffer { get; set; }

        public string NetFollowersCount { get; set; }


		public AdPageCard(Models.AdPost initData)
		{

			StartDate = (initData as Models.AdPost).PostStartDate;
			EndDate = (initData as Models.AdPost).PostEndDate;


			ServiceTypes = (initData as Models.AdPost).Compensation.ServiceType;
			CompensationOffer = (initData as Models.AdPost).Compensation.Offering.ToString();
			CompensationAccept = (initData as Models.AdPost).Compensation.Asking.ToString();	
            NetFollowersCount = (initData as Models.AdPost).NetFollowersCount.ToString();



		}



		//public Command GoToHome
		//{
		//  get
		//  {
		//      return new Command(async () =>
		//      {
		//          await CoreMethods.PushPageModel<CreateGroupPageModel>();
		//      });
		//  }
		//}
	}
}

