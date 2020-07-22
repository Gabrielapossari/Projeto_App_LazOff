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
    public partial class ApagarTarefaView : ContentPage
    {
        public ApagarTarefaView()
        {
            InitializeComponent();
        }
       
        private void VoltarListarTarefa_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new CadastrarTarefaView());
        }
    }
}