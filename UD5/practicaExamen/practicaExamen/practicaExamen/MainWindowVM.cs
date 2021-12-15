using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaExamen
{
    class MainWindowVM : ObservableObject
    {

        private PrediccionDia prediccionSelecionada;

        private ObservableCollection<PrediccionDia> predicciones;

        internal PrediccionDia PrediccionSelecionada { get => prediccionSelecionada; set => SetProperty(ref prediccionSelecionada, value); }
        internal ObservableCollection<PrediccionDia> Predicciones { get => predicciones; set => SetProperty(ref predicciones, value); }

        public MainWindowVM()
        {
            Predicciones = PrediccionDia.ObtenerDatos();
        }


    }
}
