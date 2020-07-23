using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lazyoff_App.ViewModels
{
    public class PrincipalViewModel
    {
        public string DiaTratado
        {
            get
            {
                var now = DateTime.Now;
                CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-BR");
                var date = string.Format("{2}", "D", "pt-BR", now.ToString("D", culture));
                return date.Remove((date.Length - " de 2020".Length));
            }
        }
    }
}
