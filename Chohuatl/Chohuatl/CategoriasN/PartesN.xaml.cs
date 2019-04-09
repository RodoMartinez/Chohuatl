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
	public partial class PartesN : ContentPage
	{
		public PartesN ()
		{
			InitializeComponent ();
            Imagenes();
        }

        public void Imagenes()
        {
            cabeza.Source = "Cabeza.jpg";
            pies.Source = "Pies.jpg";
            manos.Source = "Manos.jpg";
            brazo.Source = "brazo.jpg";
            piernas.Source = "piernas.jpg";
            dedos.Source = "dedos.jpg";
            oreja.Source = "oreja.jpg";
            ojos.Source = "ojos.jpg";
            nariz.Source = "nariz.jpg";
            boca.Source = "boca.jpg";
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
                case "Cabeza":
                    play("Cabeza");
                    break;
                case "Pies":
                    play("Pies");
                    break;
                case "Manos":
                    play("Manos");
                    break;
                case "Brazos":
                    play("Brazos");
                    break;
                case "Piernas":
                    play("Piernas");
                    break;
                case "Dedos":
                    play("Dedos");
                    break;
                case "Orejas":
                    play("Orejas");
                    break;
                case "Ojos":
                    play("Ojos");
                    break;
                case "Nariz":
                    play("Nariz");
                    break;
                case "Boca":
                    play("Boca");
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
            cardImage.Source = "Cabeza.jpg";
            lbl1.Text = "Cabeza";
            lbl2.Text = "Tsontegon";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            cardImage.Source = "Pies.jpg";
            lbl1.Text = "Pies";
            lbl2.Text = "Ikximej";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            cardImage.Source = "Manos.jpg";
            lbl1.Text = "Manos";
            lbl2.Text = "Mauan";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            cardImage.Source = "brazo.jpg";
            lbl1.Text = "Brazos";
            lbl2.Text = "Majkolli";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            cardImage.Source = "piernas.jpg";
            lbl1.Text = "Piernas";
            lbl2.Text = "Kostle";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            cardImage.Source = "dedos.jpg";
            lbl1.Text = "Dedos";
            lbl2.Text = "Majpil";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            cardImage.Source = "oreja.jpg";
            lbl1.Text = "Orejas";
            lbl2.Text = "Nagasjuan";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            cardImage.Source = "ojos.jpg";
            lbl1.Text = "Ojos";
            lbl2.Text = "Istelolo";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            cardImage.Source = "nariz.jpg";
            lbl1.Text = "Nariz";
            lbl2.Text = "Yegajtsol";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {
            cardImage.Source = "boca.jpg";
            lbl1.Text = "Boca";
            lbl2.Text = "Kamak";
            Rotate();
        }
    }
}