using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Chohuatl.Categorias.Animales;

namespace Chohuatl.Categorias
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Conversacion : ContentPage
	{
		public Conversacion ()
		{
			InitializeComponent ();
            Imagenes();
        }

        public void Imagenes()
        {
            buenosdias.Source = "Buenosdias.jpg";
            buenastardes.Source = "Buenastardes.jpg";
            buenasnoches.Source = "Buenasnoches.jpg";
            comoestas.Source = "Buenosdias.jpg";
            adondevas.Source = "Buenosdias.jpg";
            quehaces.Source = "Buenosdias.jpg";
            dondeestas.Source = "Buenosdias.jpg";
            hastaluego.Source = "Buenosdias.jpg";
            gracias.Source = "Buenosdias.jpg";
            nosvemos.Source = "Buenosdias.jpg";
        }

        private bool ShowDetails = false;

        private void Button_Clicked(object sender, EventArgs e)
        {//title
            Rotate();
        }

        public async void Rotate()
        {
            var cardToShow = ShowDetails ? card : details;
            var cardToHide = ShowDetails ? details : card;

            cardToShow.HasShadow = false;
            cardToHide.HasShadow = false;

            await cardToHide.RotateYTo(90, 125, Easing.Linear);
            cardToHide.IsVisible = false;

            cardToShow.RotationY = -90;
            cardToShow.IsVisible = true;

            await cardToShow.RotateYTo(0, 125, Easing.SpringOut);
            cardToShow.HasShadow = true;
            cardToHide.HasShadow = true;

            ShowDetails = !ShowDetails;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var txt = lbl1.Text;
            CrossTextToSpeech.Dispose();
            await CrossTextToSpeech.Current.Speak(txt);
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Sonido();
        }

        private void Sonido()
        {
            switch (lbl1.Text)
            {
                case "Buenos dias":
                    play("Buenosdias");
                    break;
                case "Buenas tardes":
                    play("Buenastardes");
                    break;
                case "Buenas noches":
                    play("Buenasnoches");
                    break;
                case "Como estas":
                    play("Comoestas");
                    break;
                case "A donde vas":
                    play("Adondevas");
                    break;
                case "Que haces":
                    play("Quehaces");
                    break;
                case "Donde estas":
                    play("Dondeestas");
                    break;
                case "Hasta luego":
                    play("Hastaluego");
                    break;
                case "Gracias":
                    play("Gracias");
                    break;
                case "Nos vemos":
                    play("Nosvemos");
                    break;
            }
        }

        private void play(string cancion)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load(cancion + "C.m4a");
            player.Play();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            cardImage.Source = "Buenosdias.jpg";
            lbl1.Text = "Buenos dias";
            lbl2.Text = "Sta";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            cardImage.Source = "Buenastardes.jpg";
            lbl1.Text = "Buenas tardes";
            lbl2.Text = "Sta Kunji";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            cardImage.Source = "Buenasnoches.jpg";
            lbl1.Text = "Buenas noches";
            lbl2.Text = "Sta  cutie";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            cardImage.Source = "Buenosdias.jpg";
            lbl1.Text = "Como estas";
            lbl2.Text = "Xrencha Gia";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            cardImage.Source = "Buenosdias.jpg";
            lbl1.Text = "A donde vas";
            lbl2.Text = "Xranlli tsia";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            cardImage.Source = "Buenosdias.jpg";
            lbl1.Text = "Que haces";
            lbl2.Text = "Ixre gillea";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            cardImage.Source = "Buenosdias.jpg";
            lbl1.Text = "Donde estas";
            lbl2.Text = "Xranlli Gia";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            cardImage.Source = "Buenosdias.jpg";
            lbl1.Text = "Hasta luego";
            lbl2.Text = "Tinda Chua";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            cardImage.Source = "Buenosdias.jpg";
            lbl1.Text = "Gracias";
            lbl2.Text = "Isañia";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {
            cardImage.Source = "Buenosdias.jpg";
            lbl1.Text = "Nos vemos";
            lbl2.Text = "Dubikui";
            Rotate();
        }
    }
}