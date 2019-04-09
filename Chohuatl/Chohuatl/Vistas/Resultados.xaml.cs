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
	public partial class Resultados : ContentPage
	{
		public Resultados (int buenas,int malas)
		{
			InitializeComponent ();
            double op = 100 / 6;//numero de pregunats
            double cal = op * buenas;
            buenas1.Text = "Correctas:  " + buenas;
            malas1.Text = "Incorrectas:  " + malas;
            calif.Text = "Calificacion:  " + cal;
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {//salir
            var page1 = new Principal();
            MainPage.Detalle.Detail = new NavigationPage(page1)
            {
                BarBackgroundColor = MainPage.xcolor()
            };
        }
    }
}