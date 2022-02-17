using segundaPraticaExamenFinal.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace segundaPraticaExamenFinal.Servicios
{
    class ServicioNavegacion
    {

        public void AbrirVentanaInfo() {

            (new VistaInfo()).ShowDialog();
        }

        public UserControl AbrirInfoUserControl() {

            return new InfoUserControl();

        }

    }
}
