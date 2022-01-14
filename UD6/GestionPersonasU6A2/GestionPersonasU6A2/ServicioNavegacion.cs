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



        internal UserControl AbrirListado()
        {
            return new UserControlAbrirListado();// no se tiene que crear cada vez que se llama
        }

        internal UserControl AbrirNuevaPersona()
        {
            return new UserControlNuevaPersona();
        }
    }
}
