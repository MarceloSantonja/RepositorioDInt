using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaExamen
{
    class PrediccionDia : ObservableObject
    {


        private string dia;

        public string Dia { get => dia; set => SetProperty(ref dia , value); }

        private string prediccion;

        public string Prediccion { get => prediccion; set => SetProperty(ref prediccion, value); }

        private int minimaFarenheit;

        public int MinimaFarenheit { get => minimaFarenheit; set => SetProperty(ref minimaFarenheit, value); }

        private int maximaFarenheit;

        public int MaximaFarenheit { get => maximaFarenheit; set => SetProperty(ref maximaFarenheit, value); }

        public PrediccionDia(string dia, string prediccion, int minimaFarenheit, int maximaFarenheit)
        {
            Dia = dia;
            Prediccion = prediccion;
            MinimaFarenheit = minimaFarenheit;
            MaximaFarenheit = maximaFarenheit;
        }

        public static ObservableCollection<PrediccionDia> ObtenerDatos()
        {

            ObservableCollection<PrediccionDia> resultado = new ObservableCollection<PrediccionDia>
            {
                new PrediccionDia("Lunes", "sol", 44, 60),
                new PrediccionDia("Martes", "nubes", 55, 70),
                new PrediccionDia("Miércoles", "sol", 35, 55),
                new PrediccionDia("Jueves", "nubes", 48, 65),
                new PrediccionDia("Viernes", "lluvia", 37, 50),
                new PrediccionDia("Sábado", "nubes", 30, 50),
                new PrediccionDia("Domingo", "nieve", 28, 40)
            };

            return resultado;
        }
 

    }
}
