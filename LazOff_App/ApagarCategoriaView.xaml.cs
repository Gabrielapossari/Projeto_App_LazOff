using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LazOff_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApagarCategoriaView : ContentPage
    {
        public ApagarCategoriaView()
        {
            InitializeComponent();           
        }
        private void btnVoltarMostrarCategorias(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
            
        }
       
    }
}