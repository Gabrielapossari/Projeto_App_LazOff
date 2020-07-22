using LazOff_App.View;
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
    public partial class PrincipalView : ContentPage
    {
        public PrincipalView()
        {
            InitializeComponent();


        }
     
    private void btnDeletarLista_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ApagarListaView());

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