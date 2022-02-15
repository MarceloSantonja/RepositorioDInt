using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ultimaPracticaExamen.vistas;

namespace ultimaPracticaExamen.servicio
{
    class ServicioNavegacion
    {
        public void AbrirVentataInfo(){
            (new VentanaInfo()).ShowDialog();
        }

        public  UserControl1 AbrirUserControl()
        {
            return new UserControl1();
        }
    }
}
