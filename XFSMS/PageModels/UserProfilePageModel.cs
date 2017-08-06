using System;
using FreshMvvm;
using Xamarin.Forms;
using PropertyChanged;
using System.Collections.Generic;

namespace XFSMS.Pages
{
    public class UserProfilePageModel : FreshBasePageModel
	{


		public Image _ProfileImage = new Image();

		public String _Name { get; set; }

        public String _Caption { get; set; }

		public String _Location { get; set; }
        	
		public DateTime _DOB { get; set; }

		public List<string> _PlatformHandels = new List<string>();





		public UserProfilePageModel()
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

