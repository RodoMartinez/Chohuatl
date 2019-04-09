
using Android.Media;
using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chohuatl.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Animales : ContentPage
    {
        public Animales()
        {
            InitializeComponent();
           // ac.IsRunning = false;
            Imagenes();
        }

        public void Imagenes()
        {
            //ac.IsRunning = true;
            gato.Source = "Gato.jpg";
            perro.Source = "Perro.jpg";
            caballo.Source = "Caballo.jpg";
            conejo.Source = "conejo.jpg";
            gallina.Source = "gallina.jpg";
            tortuga.Source = "tortuga.jpg";
            cerdo.Source = "cerdo.jpg";
            burro.Source = "burro.jpg";
            toro.Source = "toro.jpg";
            oveja.Source = "oveja.jpg";
            //ac.IsRunning = false;
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
            // DependencyService.Get<IAudioService>().PlayAudioFile(lbl1.Text+"C.m4a");
            Sonido();
        }

        private void Sonido()
        {
            switch (lbl1.Text)
            {
                case "Gato":
                    play("Gato");
                    break;
                case "Perro":
                    play("Perro");
                    break;
                case "Caballo":
                    play("Caballo");
                    break;
                case "Conejo":
                    play("Conejo");
                    break;
                case "Gallina":
                    play("Gallina");
                    break;
                case "Tortuga":
                    play("Tortuga");
                    break;
                case "Cerdo":
                    play("Cerdo");
                    break;
                case "Burro":
                    play("Burro");
                    break;
                case "Toro":
                    play("Toro");
                    break;
                case "Oveja":
                    play("Oveja");
                    break;
            }
        }
        private void play(string cancion)//plugin media
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load(cancion+"C.m4a");
            player.Play();
            //DependencyService.Get<IAudioService>().PlayAudioFile(cancion + "C.m4a");
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            cardImage.Source = "Gato.jpg";
            lbl1.Text = "Gato";
            lbl2.Text = "Rxìchitu";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            cardImage.Source = "Perro.jpg";
            lbl1.Text = "Perro";
            lbl2.Text = "Rxìñia";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            cardImage.Source = "Caballo.jpg";
            lbl1.Text = "Caballo";
            lbl2.Text = "Rrìxri";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            cardImage.Source = "conejo.jpg";
            lbl1.Text = "Conejo";
            lbl2.Text = "Rrìtse";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            cardImage.Source = "gallina.jpg";
            lbl1.Text = "Gallina";
            lbl2.Text = "Rrcha";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            cardImage.Source = "tortuga.jpg";
            lbl1.Text = "Tortuga";
            lbl2.Text = "Rrchenda";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            cardImage.Source = "cerdo.jpg";
            lbl1.Text = "Cerdo";
            lbl2.Text = "Rrichinga";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            cardImage.Source = "burro.jpg";
            lbl1.Text = "Burro";
            lbl2.Text = "Rriburru";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            cardImage.Source = "toro.jpg";
            lbl1.Text = "Toro";
            lbl2.Text = "Rrixrinda";
            Rotate();
        }

        private void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {
            cardImage.Source = "oveja.jpg";
            lbl1.Text = "Oveja";
            lbl2.Text = "Rrituxru";
            Rotate();
        }
    }
}