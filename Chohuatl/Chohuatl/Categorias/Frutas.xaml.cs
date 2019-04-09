using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Chohuatl.Categorias.Animales;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chohuatl.Categorias
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Frutas : ContentPage
	{
		public Frutas ()
		{
			InitializeComponent ();
            Imagenes();
        }

        public void Imagenes()
        {
            Platano.Source = "Platano.jpg";
            naranja.Source = "naranja.jpg";
            tejocote.Source = "tejocote.jpg";
            tuna.Source = "tuna.jpg";
            capulin.Source = "capulin.jpg";
            guayaba.Source = "guayaba.jpg";
            cana.Source = "cana.jpg";
            zapoteb.Source = "zapoteb.jpg";
            zapoten.Source = "zapoten.jpg";
            mamey.Source = "mamey.jpg";
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
                case "Platano":
                    play("Platano");
                    break;
                case "Naranja":
                    play("Naranja");
                    break;
                case "Tejocote":
                    play("Tejocote");
                    break;
                case "Tuna":
                    play("Tuna");
                    break;
                case "Capullin":
                    play("Capullin");
                    break;
                case "Guayaba":
                    play("Guayaba");
                    break;
                case "Caña":
                    play("Cana");
                    break;
                case "Zapote blanco":
                    play("ZapoteB");
                    break;
                case "Zapote negro":
                    play("ZapoteN");
                    break;
                case "Mamey":
                    play("Mamey");
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
            cardImage.Source = "Platano.jpg";
            lbl1.Text = "Platano";
            lbl2.Text = "Chuka";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            cardImage.Source = "naranja.jpg";
            lbl1.Text = "Naranja";
            lbl2.Text = "Naranka";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            cardImage.Source = "tejocote.jpg";
            lbl1.Text = "Tejocote";
            lbl2.Text = "Tuxa";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            cardImage.Source = "tuna.jpg";
            lbl1.Text = "Tuna";
            lbl2.Text = "Rxixre";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            cardImage.Source = "capulin.jpg";
            lbl1.Text = "Capullin";
            lbl2.Text = "Xi";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            cardImage.Source = "guayaba.jpg";
            lbl1.Text = "Guayaba";
            lbl2.Text = "Tutsegu";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            cardImage.Source = "cana.jpg";
            lbl1.Text = "Caña";
            lbl2.Text = "Zi";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            cardImage.Source = "zapoteb.jpg";
            lbl1.Text = "Zapote blanco";
            lbl2.Text = "Xide";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            cardImage.Source = "zapoten.jpg";
            lbl1.Text = "Zapote negro";
            lbl2.Text = "Xinde";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {
            cardImage.Source = "mamey.jpg";
            lbl1.Text = "Mamey";
            lbl2.Text = "Tullaju";
            Rotate();
        }
    }
}