using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XFSMS.Views
{
    public partial class StatsRibbonElement : Grid
    {
        public StatsRibbonElement()
        {
            InitializeComponent();
        }

		public static readonly BindableProperty TitleProperty = BindableProperty.Create("pTitle", typeof(string), typeof(StatsRibbonElement));

		public string pTitle
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

		public static readonly BindableProperty CountProperty = BindableProperty.Create("pCount", typeof(int), typeof(StatsRibbonElement));

		public int pCount
		{
			get
			{
				return (int)GetValue(CountProperty);
			}
			set
			{
				SetValue(CountProperty, value);
			}
		}
    }

}
