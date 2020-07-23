using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lazyoff_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApagarListaView : ContentPage
    {
        public ApagarListaView()
        {
            InitializeComponent();
        }
             private void btnVoltarMostraLista_Click(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}