using Chohuatl.MenuItems;
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
    public partial class Prueba : ContentPage
    {
        LPreguntas pregunta = new LPreguntas();
        int numero_pregunta = 1;
        int ss,buenas=0, malas=0;
        public Prueba()
        {
            InitializeComponent();
            ss = pregunta.obtener_clave();//se obtiene la clave
            preg.Text = pregunta.obtener_pregunta(ss);//se obtiene la pregunta
            Title = "Pregunta: " + numero_pregunta;
            numero_pregunta++;
        }

        private void Sig_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Respuesta.Text))
            {//siguiente pregunta
                malas++;
                Respuesta.Text = "";
            }
            else
            {
                Calificar(Respuesta.Text.ToUpper());
                Respuesta.Text = "";
            }
            if (numero_pregunta == 7)//numero de preguntas
            {
                MainPage.Detalle.Detail = new NavigationPage(new Resultados(buenas,malas))
                {
                    BarBackgroundColor = MainPage.xcolor()
                };
            }
            else
            {
                ss = pregunta.obtener_clave();
                string x = pregunta.obtener_pregunta(ss);
               // asignar_respuestas(ss);
                preg.Text = x;
                Title = "Pregunta: " + numero_pregunta;
                numero_pregunta++;
            }
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            var page1 = new Principal();
            MainPage.Detalle.Detail = new NavigationPage(page1)
            {
                BarBackgroundColor = MainPage.xcolor()
            };
            //await Navigation.PushAsync(new NavigationPage(page1) { BarBackgroundColor = MainPage.xcolor() });
        }

        public void Calificar(string Resp)
        {
            if (ss == 0) { if (Resp == "") { buenas++; } else { malas++; } }
            if (ss == 1) { if (Resp == "PANOLTISINO") { buenas++; } else { malas++; } }
            if (ss == 2) { if (Resp == "") { buenas++; } else { malas++; } }
            if (ss == 3) { if (Resp == "") { buenas++; } else { malas++; } }
            if (ss == 4) { if (Resp == "") { buenas++; } else { malas++; } }
            if (ss == 5) { if (Resp == "") { buenas++; } else { malas++; } }
            if (ss == 6) { if (Resp == "") { buenas++; } else { malas++; } }
        }
    }
}