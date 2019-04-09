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
	public partial class Cosas : ContentPage
	{
		public Cosas ()
		{
			InitializeComponent ();
            Imagenes();
        }

        public void Imagenes()
        {
            brasero.Source = "brasero.jpg";
            jarro.Source = "jarro.jpg";
            cobija.Source = "cobija.jpg";
            cazuela.Source = "cazuela.jpg";
            Plato.Source = "Plato.jpg";
            Olla.Source = "Olla.jpg";
            Silla.Source = "Silla.jpg";
            canasta.Source = "canasta.jpg";
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
                case "Brasero":
                    play("Brasero");
                    break;
                case "Jarro":
                    play("Jarro");
                    break;
                case "Cobija":
                    play("Cobija");
                    break;
                case "Cazuela":
                    play("Cazuela");
                    break;
                case "Plato":
                    play("Plato");
                    break;
                case "Olla":
                    play("Olla");
                    break;
                case "Silla":
                    play("Silla");
                    break;
                case "Canasta":
                    play("Canasta");
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
            cardImage.Source = "brasero.jpg";
            lbl1.Text = "Brasero";
            lbl2.Text = "Kùndàgi";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            cardImage.Source = "jarro.jpg";
            lbl1.Text = "Jarro";
            lbl2.Text = "Tchuà";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            cardImage.Source = "cobija.jpg";
            lbl1.Text = "Cobija";
            lbl2.Text = "Naxra";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            cardImage.Source = "cazuela.jpg";
            lbl1.Text = "Cazuela";
            lbl2.Text = "Thigu";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            cardImage.Source = "Plato.jpg";
            lbl1.Text = "Plato";
            lbl2.Text = "Jì";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            cardImage.Source = "Olla.jpg";
            lbl1.Text = "Olla";
            lbl2.Text = "Tchì";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            cardImage.Source = "Silla.jpg";
            lbl1.Text = "Silla";
            lbl2.Text = "Ndlladéctchuní";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            cardImage.Source = "canasta.jpg";
            lbl1.Text = "Canasta";
            lbl2.Text = "Ndllaxra";
            Rotate();
        }
    }
}