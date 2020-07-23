using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lazyoff_App.ViewModels
{
    public class MostrarListaViewModel
    {
        public string DiaTratado
        {
            get
            {
                var now = DateTime.Now;
                CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-BR");
               return string.Format("{2}", "D", "pt-BR", now.ToString("D", culture));
            }
        }
    }
}
