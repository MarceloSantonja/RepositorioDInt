using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace JuegoPeliculas
{
    class BackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String dificultad = value.ToString();
            Brush color = Brushes.White;
            switch (dificultad)
            {
                case "Fácil": 
                    color = Brushes.DarkSeaGreen;
                    break;
                case "Media":
                    color = Brushes.Gold;
                    break;
                case "Difícil":
                    color = Brushes.Red;
                    break;
            }

            return color;


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
