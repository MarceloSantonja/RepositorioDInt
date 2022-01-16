using System.Windows.Controls;

namespace GestionPersonasU6A2
{

    public partial class UserControlNuevaPersona : UserControl
    {
        private UserControlNuevaPersonaVM vm;
        public UserControlNuevaPersona()
        {
            InitializeComponent();
            vm = new UserControlNuevaPersonaVM();
            this.DataContext = vm;
        }
    }
}
