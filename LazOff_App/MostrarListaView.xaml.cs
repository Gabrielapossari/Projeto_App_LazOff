using Lazyoff_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lazyoff_App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MostrarListaView : ContentPage
    {
        public MostrarListaView()
        {
            InitializeComponent();
            this.BindingContext = new MostrarListaViewModel();
        }
    }
}