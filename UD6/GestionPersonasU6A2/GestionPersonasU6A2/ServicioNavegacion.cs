using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GestionPersonasU6A2
{
    class ServicioNavegacion
    {

        private static readonly UserControl listadoPersonas = new UserControlAbrirListado();

        internal UserControl AbrirListado()
        {
            return listadoPersonas;// no se tiene que crear cada vez que se llama
        }

        internal UserControl AbrirNuevaPersona()
        {
            return new UserControlNuevaPersona();
        }

        internal void AbrirVentanaNavegacion()
        {
            AddNacionalidadWindow nueva = new AddNacionalidadWindow();
            nueva.ShowDialog();
        }
    }
}
