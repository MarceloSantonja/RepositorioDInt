using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp10
{
    class ServicioNavegacion
    {
        public void AbrirVentanaHija()
        {
            VentanaHija nueva = new VentanaHija();
            nueva.ShowDialog();
        }

        internal UserControl AbrirUC2()
        {
            return new UserControl2();
        }

        internal UserControl AbrirUC1()
        {
            return new UserControl1();
        }
    }
}
