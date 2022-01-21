using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PersonasMensajes
{

    public partial class App : Application
    {
        public App()
        {
            // hay que poner el namespace del fichero delante  de la referencia a la clave
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(PersonasMensajes.Properties.Settings.Default.Clave);
        }

        
    }
}
