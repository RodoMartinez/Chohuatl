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
	public partial class Contacto : ContentPage
	{
		public Contacto ()
		{
			InitializeComponent ();
            sw.IsToggled = Convert.ToBoolean(Vistas.Settings.EstadoTutorial);
            sw2.IsToggled = Vistas.Settings.Estilo;
            if (Convert.ToBoolean(Vistas.Settings.EstadoTutorial) == true)
                lbl1.Text = "Tutorial activo";
            else
                lbl1.Text = "Tutorial desactivado";
            if (Vistas.Settings.Estilo == true)
                lbl2.Text = "Estilo Claro";
            else
                lbl2.Text = "Estilo Obscuro";
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            Vistas.Settings.EstadoTutorial = e.Value.ToString();
            if (Convert.ToBoolean(Vistas.Settings.EstadoTutorial) == true)
                lbl1.Text = "Tutorial activo";
            else
                lbl1.Text = "Tutorial desactivado";
        }

        private void Sw2_Toggled(object sender, ToggledEventArgs e)
        {
            Vistas.Settings.Estilo = Convert.ToBoolean(e.Value.ToString());
            if (Vistas.Settings.Estilo == true)
                lbl2.Text = "Estilo Claro";
            else
                lbl2.Text = "Estilo Obscuro";
        }
    }
}