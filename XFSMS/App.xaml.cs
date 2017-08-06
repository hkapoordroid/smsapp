using Xamarin.Forms;
using FreshMvvm;
namespace XFSMS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SetUpIOC();
            var Page = FreshPageModelResolver.ResolvePageModel<Pages.MenuPageModel>();
            var nav = SetUpMasterDetailNavigation();

            MainPage = nav;
            //SetUpIOC();
        }

        public FreshMvvm.FreshMasterDetailNavigationContainer SetUpMasterDetailNavigation()
        {
            var nav = new FreshMvvm.FreshMasterDetailNavigationContainer();
            // = Color.AliceBlue;

            nav.Init("Menu");
            nav.AddPage<Pages.ExplorePageModel>("Explore");
            nav.AddPage<Pages.HomePageModel>("Home");
            nav.AddPage<Pages.CreateAdPageModel>("Create Ad");
			nav.AddPage<Pages.CreateEventPageModel>("Create Event");
            nav.AddPage<Pages.SettingsPageModel>("Settings");
            nav.AddPage<Pages.HelpPageModel>("Help");
            nav.AddPage<Pages.UserProfilePageModel>("Profile");
            (nav.Master as Page).BackgroundColor = Color.FromHex("fbe9e7");

            foreach (NavigationPage npg in nav.Pages.Values)
            {
                npg.BarBackgroundColor = Color.FromHex("c8b7b5");
            }
            return nav;
        }

        public void SetUpIOC ()
        {
            //fresh
            FreshIOC.Container.Register<Services.IAuthenticateService, Services.AuthenticateService>();
            FreshIOC.Container.Register<Services.IDataService,Services.DataService>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
