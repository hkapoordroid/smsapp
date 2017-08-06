using System;
using FreshMvvm;
using Xamarin.Forms;
using PropertyChanged;

namespace XFSMS.Pages
{
	[AddINotifyPropertyChangedInterface]
	public class ForgotPageModel : FreshBasePageModel
	{

		public String _Email { get; set; }

		//public String _Password { get; set; }

		public Services.IAuthenticateService _AuthService;

		public ForgotPageModel(Services.IAuthenticateService AuthService)
		{
			_AuthService = AuthService;
		}


		public override void Init(object initData)
		{
			base.Init(initData);

		}



		public Command SubmitEmail
		{
			get
			{
				return new Command(async () =>
				{
					await CoreMethods.PushPageModel<HomePageModel>();
				});
			}

		}

	}
}
