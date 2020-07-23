using Lazyoff_App.View;
using Lazyoff_App.ViewModels;
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
    public partial class PrincipalView : ContentPage
    {
        public PrincipalView()
        {
            InitializeComponent();
            this.BindingContext = new PrincipalViewModel();
        }
     
    private void btnDeletarLista_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new ApagarListaView());
        }
       
        async void btnMostrarLista_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarTarefaView());
        }


        async void Pesquisar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PesquisarView());
        }
        async void btnCadastrarLista_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarListaView());
        }

    }
}