using System;

using Xamarin.Forms;

namespace XFSMS.Pages
{
    public class GroupMembersPageModel : ContentPage
    {
        public GroupMembersPageModel()
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

