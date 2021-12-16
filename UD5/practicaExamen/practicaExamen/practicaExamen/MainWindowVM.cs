using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace practicaExamen
{
    class MainWindowVM : ObservableObject
    {

        private PrediccionDia prediccionSelecionada;

        private ObservableCollection<PrediccionDia> predicciones;

        public PrediccionDia PrediccionSelecionada { get => prediccionSelecionada; set => SetProperty(ref prediccionSelecionada, value); }
        public ObservableCollection<PrediccionDia> Predicciones { get => predicciones; set => SetProperty(ref predicciones, value); }

        public MainWindowVM()
        {
            Predicciones = PrediccionDia.ObtenerDatos();
        }


    }
}
