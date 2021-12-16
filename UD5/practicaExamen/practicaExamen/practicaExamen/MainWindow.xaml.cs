using System.Windows;

namespace practicaExamen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly MainWindowVM vm = new MainWindowVM();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}
