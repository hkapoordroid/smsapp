using System;

using Xamarin.Forms;

namespace XFSMS.Pages
{
    public class StatisticsPageModel : ContentPage
    {
        public StatisticsPageModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

