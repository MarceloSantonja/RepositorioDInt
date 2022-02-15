using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimaPracticaExamen.VistaModelo
{
    class VentanaInfoVM :ObservableObject
    {
        private String titulo;

        public String Titulo
        {
            get { return titulo; }
            set {SetProperty(ref titulo , value); }
        }
        private String autor;

        public String Autor
        {
            get { return autor; }
            set { SetProperty(ref autor, value); }
        }
        private String version;

        public String Version
        {
            get { return version; }
            set { SetProperty(ref version, value); }
        }

        public VentanaInfoVM()
        {
            Version = Properties.Settings.Default.Version;
            Autor = Properties.Settings.Default.Autor;
            Titulo = Properties.Settings.Default.Titulo;
        }
    }
}
