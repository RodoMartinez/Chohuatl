using Chohuatl.Categorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chohuatl.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Chocholteco : ContentPage
	{
		public Chocholteco ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //Navigation.PopToRootAsync(false);

            MainPage.Detalle.Detail = new NavigationPage(new Animales())
            {
                BarBackgroundColor=MainPage.xcolor()
            };

            //App.MasterD.Detail= new NavigationPage((Page)Activator.CreateInstance(typeof(Animales)));
            //App.MasterD.Detail = new NavigationPage(new Animales());
            //var Page = new Animales();
            //NavigationPage.SetHasNavigationBar(Page, false);
            //NavigationPage.SetHasBackButton(Page, false);
            //await Navigation.PushAsync(new NavigationPage(Page));

        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            MainPage.Detalle.Detail = new NavigationPage(new Colores())
            {
                BarBackgroundColor = MainPage.xcolor()
            };

        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            MainPage.Detalle.Detail = new NavigationPage(new Numeros())
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            MainPage.Detalle.Detail = new NavigationPage(new Partes())
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            MainPage.Detalle.Detail = new NavigationPage(new Frutas())
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            MainPage.Detalle.Detail = new NavigationPage(new Verduras())
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            MainPage.Detalle.Detail = new NavigationPage(new Conversacion())
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            MainPage.Detalle.Detail = new NavigationPage(new Cosas())
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }
    }
}