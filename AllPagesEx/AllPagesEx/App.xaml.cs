using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AllPagesEx
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationPage navi = new NavigationPage(new MainPage());
            navi.BarBackgroundColor = Color.FromHex("#00FF00");
            MainPage = navi;


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
