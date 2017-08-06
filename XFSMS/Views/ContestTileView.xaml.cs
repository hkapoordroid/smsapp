using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace XFSMS.Views
{
    public partial class ContestTileView : StackLayout
    {
        public ContestTileView()
        {
            InitializeComponent();
        }


		public static readonly BindableProperty CountAffinityProperty = BindableProperty.Create("InstaLikes", typeof(int), typeof(StatsRibbonElement));

		public int InstaLikes
		{
			get
			{
				return (int)GetValue(CountAffinityProperty);
			}
			set
			{
				SetValue(CountAffinityProperty, value);
			}
		}



		public static readonly BindableProperty CountTalksProperty = BindableProperty.Create("InstaComments", typeof(int), typeof(StatsRibbonElement));

		public int InstaComments
		{
			get
			{
				return (int)GetValue(CountTalksProperty);
			}
			set
			{
				SetValue(CountTalksProperty, value);
			}
		}


		public static readonly BindableProperty CountCrowdProperty = BindableProperty.Create("InstaFollowers", typeof(int), typeof(StatsRibbonElement));

		public int InstaFollowers
		{
			get
			{
				return (int)GetValue(CountCrowdProperty);
			}
			set
			{
				SetValue(CountCrowdProperty, value);
			}
		}

	}
}
