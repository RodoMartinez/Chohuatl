using System;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Chohuatl
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterD { set; get; }
        public App()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(Chohuatl.Vistas.Settings.EstadoTutorial))
                Chohuatl.Vistas.Settings.EstadoTutorial = "true";
            MainPage = new NavigationPage(new Chohuatl.Vistas.SplashScreen());

            //var Page = new Chohuatl.Vistas.Tuto();
            //MainPage =new NavigationPage(Page);
            //NavigationPage.SetHasNavigationBar(Page, false);
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
