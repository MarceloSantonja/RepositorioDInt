using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploComando
{
    class ServicioNavegacion
    {

        public void AbrirVentanaHija() {

            VentanaHija v = new VentanaHija();
            v.ShowDialog();
        
        
        }
    }
}
