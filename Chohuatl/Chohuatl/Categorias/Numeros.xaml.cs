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
	public partial class Numeros : ContentPage
	{
		public Numeros ()
		{
			InitializeComponent ();
            Imagenes();
        }

        public void Imagenes()
        {
            Uno.Source= "Uno.jpg";
            Dos.Source = "Dos.jpg";
            Tres.Source = "Tres.jpg";
            cuatro.Source = "cuatro.jpg";
            cinco.Source = "cinco.jpg";
            seis.Source = "seis.jpg";
            siete.Source = "siete.jpg";
            ocho.Source = "ocho.jpg";
            nueve.Source = "nueve.jpg";
            diez.Source = "diez.jpg";
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
                case "Uno":
                    play("Uno");
                    break;
                case "Dos":
                    play("Dos");
                    break;
                case "Tres":
                    play("Tres");
                    break;
                case "Cuatro":
                    play("Cuatro");
                    break;
                case "Cinco":
                    play("Cinco");
                    break;
                case "Seis":
                    play("Seis");
                    break;
                case "Siete":
                    play("Siete");
                    break;
                case "Ocho":
                    play("Ocho");
                    break;
                case "Nueve":
                    play("Nueve");
                    break;
                case "Diez":
                    play("Diez");
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
            cardImage.Source = "Uno.jpg";
            lbl1.Text = "Uno";
            lbl2.Text = "Ngu";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            cardImage.Source = "Dos.jpg";
            lbl1.Text = "Dos";
            lbl2.Text = "Llu";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            cardImage.Source = "Tres.jpg";
            lbl1.Text = "Tres";
            lbl2.Text = "Ñie";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            cardImage.Source = "cuatro.jpg";
            lbl1.Text = "Cuatro";
            lbl2.Text = "Ñu";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            cardImage.Source = "cinco.jpg";
            lbl1.Text = "Cinco";
            lbl2.Text = "Lluu";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            cardImage.Source = "seis.jpg";
            lbl1.Text = "Seis";
            lbl2.Text = "Xu";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            cardImage.Source = "siete.jpg";
            lbl1.Text = "Siete";
            lbl2.Text = "Lladu";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            cardImage.Source = "ocho.jpg";
            lbl1.Text = "Ocho";
            lbl2.Text = "Xi";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            cardImage.Source = "nueve.jpg";
            lbl1.Text = "Nueve";
            lbl2.Text = "Na";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {

            cardImage.Source = "diez.jpg";
            lbl1.Text = "Diez";
            lbl2.Text = "Te";
            Rotate();
        }
    }
}