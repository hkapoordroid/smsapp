using System;
using FreshMvvm;
using Xamarin.Forms;
using PropertyChanged;
using System.Collections.Generic;

namespace XFSMS.Pages
{
	public class CreateAdPageModel : FreshBasePageModel
	{
		public List<Models.User> Owners = new List<Models.User>();

		public List<Models.User> Members = new List<Models.User>();

		public string _Title { get; set; }

		public string _Description { get; set; }

		public Models.Constants.ServiceTypes _ServiceTypes { get; set; }

		public DateTime _StartDate { get; set; }

		public DateTime _EndDate { get; set; }

		public int _CompensationAccept { get; set; }

        public int _CompensationOffer{ get; set; }

		public string _TargetLocation { get; set; }

		public string _TargetAgeRange { get; set; }

        

		public CreateAdPageModel()
		{


		}





		public override void Init(object initData)
		{
			base.Init(initData);
 
            /*
            Owners = (initData as Models.AdPost)._Owners;
            Members = (initData as Models.AdPost)._Members;
            _Title = (initData as Models.AdPost)._Heading;
            _Description = (initData as Models.AdPost)._Description;
            _StartDate = (initData as Models.AdPost)._PostStartDate;
            _EndDate = (initData as Models.AdPost)._PostEndDate;

			_ServiceTypes = (initData as Models.AdPost)._Compensation.ServiceType;
			_CompensationOffer = (initData as Models.AdPost)._Compensation.DollarsOffering;
			_CompensationAccept = (initData as Models.AdPost)._Compensation.DollarsAsking;
            _TargetLocation = (initData as Models.AdPost)._ShareCriteria._Locations[0].ToString();
*/
		}

		protected override void ViewIsAppearing(object sender, EventArgs e)
		{
			base.ViewIsAppearing(sender, e);
		}

		public override void ReverseInit(object returnedData)
		{
			base.ReverseInit(returnedData);
		}

		protected override void ViewIsDisappearing(object sender, EventArgs e)
		{
			base.ViewIsDisappearing(sender, e);
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


