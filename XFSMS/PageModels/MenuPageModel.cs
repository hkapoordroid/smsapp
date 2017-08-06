using System;
using FreshMvvm;
using Xamarin.Forms;
using PropertyChanged;
using System.Collections.Generic;
namespace XFSMS.Pages
{
	[AddINotifyPropertyChangedInterface]
	public class MenuPageModel : FreshBasePageModel
	{

		public List<String> _MenuItems { get; set; }

        public string _selectedItem { get; set; }

		public MenuPageModel()
		{

		}


		public override void Init(object initData)
		{
			base.Init(initData);
			_MenuItems = new List<string>();
			_MenuItems.Add("Search");
			_MenuItems.Add("Home");
			_MenuItems.Add("Create Event");
			_MenuItems.Add("Create Ads");
			_MenuItems.Add("Create Teams");
			_MenuItems.Add("Profile");
			_MenuItems.Add("Settings");
			_MenuItems.Add("Help");
		}

		public string SelectedItem
		{
			get
			{
				return _selectedItem;
			}
			set
			{
				_selectedItem = value;

				if (_selectedItem == null)
					return;

				ItemClicked.Execute(_selectedItem);

				SelectedItem = null;
			}
		}

		public Command ItemClicked
		{
			get
			{
				return new Command(async () =>
				{

					switch (SelectedItem)
					{
						case "Search":
							
							break;
						case "Home":
                            await CoreMethods.PushPageModel<HomePageModel>();
							break;
						case "Create Event":
                            await CoreMethods.PushPageModel<CreateEventPageModel>();
							break;
						case "Create Ads":
                            await CoreMethods.PushPageModel<CreateAdPageModel>();
							break;
						case "Create Teams":
                            
							break;
						case "Profile":
                            await CoreMethods.PushPageModel<UserProfilePageModel>();
							break;

						case "Settings":
                            await CoreMethods.PushPageModel<SettingsPageModel>();
							break;
						case "Help":
							//var modalPage = FreshPageModelResolver.ResolvePageModel<>ModalPageModel & gt; ();
							//await PushPage(modalPage, null, true);
							break;
						default:
							break;
					}

				});
			}

		}

	}
}
