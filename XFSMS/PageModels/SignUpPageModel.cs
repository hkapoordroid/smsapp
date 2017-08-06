﻿using System;
using FreshMvvm;
using Xamarin.Forms;
using PropertyChanged;

namespace XFSMS.Pages
{
	[AddINotifyPropertyChangedInterface]
	public class SignUpPageModel : FreshBasePageModel
	{

		public String _UserName { get; set; }

		public String _Password { get; set; }

        public String _ConfirmedPassword { get; set; }

		public Services.IAuthenticateService _AuthService;

		public SignUpPageModel(Services.IAuthenticateService AuthService)
		{
			_AuthService = AuthService;
		}


		public override void Init(object initData)
		{
			base.Init(initData);

		}



		public Command GoToHome
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