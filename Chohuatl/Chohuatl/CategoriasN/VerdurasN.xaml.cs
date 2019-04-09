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
	public partial class VerdurasN : ContentPage
	{
		public VerdurasN ()
		{
			InitializeComponent ();
            Imagenes();
        }

        public void Imagenes()
        {
            aguacate.Source = "Aguacate.jpg";
            papa.Source = "Papa.jpg";
            calabaza.Source = "calabaza.jpg";
            cebolla.Source = "cebolla.jpg";
            jitomate.Source = "jitomate.jpg";
            tomate.Source = "tomate.jpg";
            quelite.Source = "quelite.jpg";
            chile.Source = "chile.jpg";
            elote.Source = "elote.jpg";
            huitlacoche.Source = "huitlacoche.jpg";
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
                case "Aguacate":
                    play("Aguacate");
                    break;
                case "Camote":
                    play("Papa");
                    break;
                case "Calabaza":
                    play("Calabaza");
                    break;
                case "Cebolla":
                    play("Cebolla");
                    break;
                case "Jitomate":
                    play("Jitomate");
                    break;
                case "Tomate":
                    play("Tomate");
                    break;
                case "Quelite":
                    play("Quelite");
                    break;
                case "Chiles":
                    play("Chiles");
                    break;
                case "Elote":
                    play("Elote");
                    break;
                case "Huitlacoche":
                    play("Huitlacoche");
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
            cardImage.Source = "Aguacate.jpg";
            lbl1.Text = "Aguacate";
            lbl2.Text = "Aguakatl";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            cardImage.Source = "Papa.jpg";
            lbl1.Text = "Camote";
            lbl2.Text = "Camohtli";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            cardImage.Source = "calabaza.jpg";
            lbl1.Text = "Calabaza";
            lbl2.Text = "Ayojtle";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            cardImage.Source = "cebolla.jpg";
            lbl1.Text = "Cebolla";
            lbl2.Text = "Xonakatl";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            cardImage.Source = "jitomate.jpg";
            lbl1.Text = "Jitomate";
            lbl2.Text = "Xitomatl";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            cardImage.Source = "tomate.jpg";
            lbl1.Text = "Tomate";
            lbl2.Text = "Tomatl";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            cardImage.Source = "quelite.jpg";
            lbl1.Text = "Quelite";
            lbl2.Text = "Quilitl";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            cardImage.Source = "chile.jpg";
            lbl2.Text = "Chijli";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            cardImage.Source = "elote.jpg";
            lbl1.Text = "Chiles";
            lbl1.Text = "Elote";
            lbl2.Text = "Yelotl";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {
            cardImage.Source = "huitlacoche.jpg";
            lbl1.Text = "Huitlacoche";
            lbl2.Text = "Huitlacoche";
            Rotate();
        }
    }
}