using System;
using FreshMvvm;
using Xamarin.Forms;
using PropertyChanged;
using System.Collections.Generic;

namespace XFSMS.Pages
{
    public class AdInfoPageModel : FreshBasePageModel
	{
		public List<Models.User> Owners = new List<Models.User>();

        public List<Models.User> _InterestedMembers = new List<Models.User>();

		public String _Title { get; set; }

		public String _Description { get; set; }

        public String _Goals { get; set; }

		public DateTime _StartDate { get; set; }

        public DateTime _EndDate { get; set; }

		public int _CriteriaFollowers { get; set; }

        public int _AcceptAmount { get; set; }

        public int _OfferAmount{ get; set; }

		public string _Location { get; set; }

		public String _AgeRange { get; set; }

        public AdInfoPageModel()
		{

		}

		public override void Init(object initData)
		{
			base.Init(initData);



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

