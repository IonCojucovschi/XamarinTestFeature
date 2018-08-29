using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StartupCore.Views;
using System.Threading.Tasks;
using StartupCore.Bootstrap;
using StartupCore.Contracts.Services.General;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace StartupCore
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            InitializeApp();

            InitializeNavigation();

            MainPage = new MainPage();
        }


        private async Task InitializeNavigation()
        {
            var navigationService = AppContainer.Resolve<INavigationService>();
            await navigationService.InitializeAsync();
        }

        private void InitializeApp()
        {
            AppContainer.RegisterDependencies();

            ///implement messenger loginc wit sender,,,and ....

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
