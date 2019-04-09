using Chohuatl.CategoriasN;
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
	public partial class Nahuatl : ContentPage
	{
		public Nahuatl ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            App.MasterD.Detail = new NavigationPage(new AnimalesN())
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            App.MasterD.Detail = new NavigationPage(new ColoresN())
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            App.MasterD.Detail = new NavigationPage(new NumerosN())
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            App.MasterD.Detail = new NavigationPage(new PartesN())
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            App.MasterD.Detail = new NavigationPage(new FrutasN())
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            App.MasterD.Detail = new NavigationPage(new VerdurasN())
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            App.MasterD.Detail = new NavigationPage(new ConversacionN())
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            App.MasterD.Detail = new NavigationPage(new CosasN())
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }
    }
}