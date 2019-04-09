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
    public partial class Tuto : CarouselPage
    {
        public Tuto()
        {
            InitializeComponent();
            Vistas.Settings.EstadoTutorial = "true";
        }

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    //var Page = new MainPage();
        //    //NavigationPage.SetHasNavigationBar(Page, false);
        //    //NavigationPage.SetHasBackButton(Page, false);
        //    //await Navigation.PushAsync(Page);
        //    await Navigation.PopAsync();
        //}
    }
}