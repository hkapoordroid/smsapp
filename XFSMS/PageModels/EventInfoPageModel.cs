using System;
using FreshMvvm;
using Xamarin.Forms;
using PropertyChanged;
using System.Collections.Generic;

namespace XFSMS.Pages
{
    public class EventInfoPageModel : FreshBasePageModel
	{


		public Image _EventImage = new Image();

		public String _Title { get; set; }

		public String _Description { get; set; }

		public DateTime _StartDate { get; set; }

		public DateTime _EndDate { get; set; }

		public string EventType { get; set; }

		public List<Models.User> Owners = new List<Models.User>();

		public List<Models.User> Members = new List<Models.User>();

		public List<string> _ReachByPlatform = new List<string>();

		public List<string> _ReachByGeography = new List<string>();


		public EventInfoPageModel()
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

