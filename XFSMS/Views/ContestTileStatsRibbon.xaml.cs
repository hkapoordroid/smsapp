using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XFSMS.Views
{
    public partial class ContestTileStatsRibbon : Grid
    {
        public ContestTileStatsRibbon()
        {
            InitializeComponent();
        }



		public static readonly BindableProperty txtAffinityProperty = BindableProperty.Create("TxtAffinity", typeof(string), typeof(StatsRibbonElement));

		public string TxtAffinity
		{
			get
			{
				return (string)GetValue(txtAffinityProperty);
			}
			set
			{
				SetValue(txtAffinityProperty, value);
			}
		}

		public static readonly BindableProperty CountAffinityProperty = BindableProperty.Create("CountAffinity", typeof(int), typeof(StatsRibbonElement));

		public string CountAffinity
		{
			get
			{
				return (string)GetValue(CountAffinityProperty);
			}
			set
			{
				SetValue(CountAffinityProperty, value);
			}
		}

		public static readonly BindableProperty txtTalksProperty = BindableProperty.Create("TxtTalks", typeof(string), typeof(StatsRibbonElement));

		public string TxtTalks
		{
			get
			{
				return (string)GetValue(txtTalksProperty);
			}
			set
			{
				SetValue(txtTalksProperty, value);
			}
		}

		public static readonly BindableProperty CountTalksProperty = BindableProperty.Create("CountTalks", typeof(int), typeof(StatsRibbonElement));

		public string CountTalks
		{
			get
			{
				return (string)GetValue(CountTalksProperty);
			}
			set
			{
				SetValue(CountTalksProperty, value);
			}
		}

		public static readonly BindableProperty TxtCrowdProperty = BindableProperty.Create("TxtCrowd", typeof(string), typeof(StatsRibbonElement));

		public string TxtCrowd
		{
			get
			{
				return (string)GetValue(TxtCrowdProperty);
			}
			set
			{
				SetValue(TxtCrowdProperty, value);
			}
		}

		public static readonly BindableProperty CountCrowdProperty = BindableProperty.Create("CountCrowd", typeof(int), typeof(StatsRibbonElement));

		public string CountCrowd
		{
			get
			{
				return (string)GetValue(CountCrowdProperty);
			}
			set
			{
				SetValue(CountCrowdProperty, value);
			}
		}
    }
}
