using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CoursatyMobApp.Services;
using CoursatyMobApp.Views;
using CoursatyMobApp.Views.Users;

namespace CoursatyMobApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
