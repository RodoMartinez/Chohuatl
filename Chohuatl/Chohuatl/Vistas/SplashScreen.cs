
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Chohuatl.Vistas
{
    public class SplashScreen:ContentPage
    {
        Image Splashscreen;
        public SplashScreen()
        {
            NavigationPage.SetHasNavigationBar(this,false);
            var sub = new AbsoluteLayout();
            Splashscreen = new Image
            {
                Source = "iconC.jpg",
                HeightRequest = 100,
                WidthRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(Splashscreen,
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(Splashscreen,
                new Rectangle(0.5,0.5,AbsoluteLayout.AutoSize,AbsoluteLayout.AutoSize));
            sub.Children.Add(Splashscreen);
            this.BackgroundColor = Color.FromHex("#429de3");
            this.Content = sub;
        }

        //private string Imgs()
        //{
        //    string s = "";
        //    Random rn = new Random();
        //    int im = rn.Next(1, 11);
        //    switch (im)
        //    {
        //        case 1: s = "Perro.jpg"; break;
        //        case 2: s = "ojos.jpg"; break;
        //        case 3: s = "Buenasnoches.jpg"; break;
        //        case 4: s = "Buenosdias.jpg"; break;
        //        case 5: s = "cerdo.jpg"; break;
        //        case 6: s = "conejo.jpg"; break;
        //        case 7: s = "Gato.jpg"; break;
        //        case 8: s = "guayaba.jpg"; break;
        //        case 9: s = "gallina.jpg"; break;
        //        case 10: s = "zapoteb.jpg"; break;
        //        default: s = "tuna.jpg"; break;
        //    }
        //    return s;
        //}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Splashscreen.ScaleTo(1,2000);
            await Splashscreen.ScaleTo(0.9, 1500,Easing.Linear);
            await Splashscreen.ScaleTo(150, 1200,Easing.Linear);
            //if (Convert.ToBoolean(Vistas.Settings.EstadoTutorial) != false)
            //{//si es falso esta desactivada la del tutorial
            //    var Page = new Chohuatl.Vistas.Tuto();
            //    Application.Current.MainPage = new NavigationPage(Page);
            //    NavigationPage.SetHasNavigationBar(Page, false);
            //}
            //else
            //{
                var Page = new MainPage();
                Application.Current.MainPage = new NavigationPage(Page);
                NavigationPage.SetHasNavigationBar(Page, false);
            //}

        }
    }
}
