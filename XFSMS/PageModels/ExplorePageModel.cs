using System;
using FreshMvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using PropertyChanged;

namespace XFSMS.Pages
{
	[AddINotifyPropertyChangedInterface]
    public class ExplorePageModel:FreshBasePageModel
    {
		public ObservableCollection<Models.AdPost> FeaturedAds { get; set; }

		public Services.IDataService _DataService;
        public ExplorePageModel(Services.IDataService DataService)
        {
			_DataService = DataService;

			FeaturedAds = new ObservableCollection<Models.AdPost>();
			FeaturedAds = _DataService.GetAdsFeatured();

		}





		public override void Init(object initData)
		{
			base.Init(initData);




		}




		protected override void ViewIsAppearing(object sender, EventArgs e)
		{

		}

		public Command ShowDetail
		{
			get
			{
				return new Command(async () =>
				{
					await CoreMethods.PushPageModel<EventInfoPageModel>();
				});
			}

		}

	}

}
