using Android.App;
using Chohuatl.Categorias;
using Chohuatl.MenuItems;
using Chohuatl.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chohuatl
{
    public partial class MainPage : MasterDetailPage
    {
        //closer?.closeApplication();
        public static MasterDetailPage Detalle { set; get; }

        public List<MasterMenuItem> menuList
        {
            get;
            set;
        }
        public MainPage()
        {
            InitializeComponent();
            menuList = new List<MasterMenuItem>();
            // Adding menu items to menuList and you can define title ,page and icon  
            menuList.Add(new MasterMenuItem() { Title = "Principal", Icon = "Principal.png", TargetType = typeof(Principal) });
            menuList.Add(new MasterMenuItem() { Title = "Chocholteco", Icon = "Chocholteco.png", TargetType = typeof(Chocholteco) });
            menuList.Add(new MasterMenuItem() { Title = "Nahuatl", Icon = "Nahuatl.png", TargetType = typeof(Nahuatl) });
            menuList.Add(new MasterMenuItem() { Title = "Prueba", Icon = "Principal.png", TargetType = typeof(Prueba) });
            menuList.Add(new MasterMenuItem() { Title = "Configuracion", Icon = "Contacto.png", TargetType = typeof(Contacto) });

            // Setting our list to be ItemSource for ListView in MainPage.xaml  
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page  
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Principal)))
            {
                BarBackgroundColor = xcolor()
            };

        App.MasterD = this;
            Detalle = this;
            tutorial();
        }

        public static Color xcolor()
        {
            if (Chohuatl.Vistas.Settings.Estilo == true)
            {
                return Color.DeepSkyBlue;
            }
            else
            {
               return Color.Black;
            }
        }

        public async void tutorial()
        {
            if (Convert.ToBoolean(Vistas.Settings.EstadoTutorial) != false)
            {
                var page1 = new Tuto();
                NavigationPage.SetHasNavigationBar(page1, false);
                NavigationPage.SetHasBackButton(page1, false);
                await Navigation.PushAsync(new NavigationPage(page1) { BarBackgroundColor = xcolor() });
            }
        }

        //public interface ICloseApplication
        //{
        //    void closeApplication();
        //}
        // Event for Menu Item selection, here we are going to handle navigation based  
        // on user selection in menu ListView  
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //int tuto=0;
            //if (Convert.ToBoolean(Vistas.Settings.EstadoTutorial) != false)
            //{
            //    tuto = 1;
            //    Vistas.Settings.EstadoTutorial = "false";
            //}
                var item = (MasterMenuItem)e.SelectedItem;
            if (item != null)
            {
                Navigation.PopToRootAsync(false);
                Type page = item.TargetType;
                Detail = new NavigationPage((Page)Activator.CreateInstance(page))
                {
                    BarBackgroundColor = xcolor()
                };
                navigationDrawerList.SelectedItem = null;
                IsPresented = false;
                //navigationDrawerList.SelectionMode = ListViewSelectionMode.None
            }

            //if (tuto == 1)
            //{
            //    Vistas.Settings.EstadoTutorial = "true";
            //}
        }
        /// <summary>
        /// </summary>
        /// <returns></returns>
        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () => 
            { 
                var result = await DisplayAlert("Alerta!", "Desea salir de Chohuatl?", "Salir", "Cancelar");
                if (result)
                {
                    //System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
                else
                {
                //await this.Navigation.PopAsync();
                }
        });
            return true;
        }
    }
}
