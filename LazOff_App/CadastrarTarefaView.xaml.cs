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
    public partial class CadastrarTarefaView : ContentPage
    {
        public CadastrarTarefaView()
        {
            InitializeComponent();
        }
        private void DeletarTarefa_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ApagarTarefaView());
        }
        
    }
}