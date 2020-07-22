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
    public partial class ListarCategoriasView : ContentPage
    {
        public ListarCategoriasView()
        {
            InitializeComponent();
        }
      
        private void btnDeletarCategoria_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ApagarCategoriaView());
        }
        async void btnAdicionarCategoria_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarCategoriaView());
        }
       
}
}