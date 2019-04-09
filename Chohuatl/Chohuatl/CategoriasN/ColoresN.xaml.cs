using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Chohuatl.Categorias.Animales;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chohuatl.CategoriasN
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ColoresN : ContentPage
	{
		public ColoresN ()
		{
			InitializeComponent ();
            Imagenes();
        }

        public void Imagenes()
        {
            rojo.Source = "Rojo.jpg";
            verde.Source = "Verde.jpg";
            azul.Source = "Azul.jpg";
            anaranjado.Source = "anaranjado.jpg";
            rosa.Source = "rosa.jpg";
            amarillo.Source = "amarillo.jpg";
            gris.Source = "gris.jpg";
            negro.Source = "negro.jpg";
            blanco.Source = "blanco.jpg";
            morado.Source = "morado.jpg";
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
            // DependencyService.Get<IAudioService>().PlayAudioFile(lbl1.Text + "C.m4a");
            Sonido();
        }

        private void Sonido()
        {
            switch (lbl1.Text)
            {
                case "Rojo":
                    play("Rojo");
                    break;
                case "Verde":
                    play("Verde");
                    break;
                case "Azul":
                    play("Azul");
                    break;
                case "Anaranjado":
                    play("Anaranjado");
                    break;
                case "Rosa":
                    play("Rosa");
                    break;
                case "Amarillo":
                    play("Amarillo");
                    break;
                case "Gris":
                    play("Gris");
                    break;
                case "Negro":
                    play("Negro");
                    break;
                case "Blanco":
                    play("Blanco");
                    break;
                case "Morado":
                    play("Morado");
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
            cardImage.Source = "Rojo.jpg";
            lbl1.Text = "Rojo";
            lbl2.Text = "Chichiltik";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            cardImage.Source = "Verde.jpg";
            lbl1.Text = "Verde";
            lbl2.Text = "Xoxoktik";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            cardImage.Source = "Azul.jpg";
            lbl1.Text = "Azul";
            lbl2.Text = "Yauitl";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            cardImage.Source = "anaranjado.jpg";
            lbl1.Text = "Anaranjado";
            lbl2.Text = "Ayopali";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            cardImage.Source = "rosa.jpg";
            lbl1.Text = "Rosa";
            lbl2.Text = "Xochitik";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            cardImage.Source = "amarillo.jpg";
            lbl1.Text = "Amarillo";
            lbl2.Text = "Kostik";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            cardImage.Source = "gris.jpg";
            lbl1.Text = "Gris";
            lbl2.Text = "Nextik";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            cardImage.Source = "negro.jpg";
            lbl1.Text = "Negro";
            lbl2.Text = "Kapotstik";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            cardImage.Source = "blanco.jpg";
            lbl1.Text = "Blanco";
            lbl2.Text = "Istaktik";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {
            cardImage.Source = "morado.jpg";
            lbl1.Text = "Morado";
            lbl2.Text = "Kajkamoktik";
            Rotate();
        }
    }
}