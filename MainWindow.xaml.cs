using ElectricalTest.UsrControl;
using ElectricalTest.Wndow;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ElectricalTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void WMain_Loaded(object sender, RoutedEventArgs e)
        {
            //int screenWidth = (int)SystemParameters.PrimaryScreenWidth;
            //int screenHeight = (int)SystemParameters.PrimaryScreenHeight;
            //txtBTitle.Text += $"Res: {screenWidth} x {screenHeight}";


            RenderPages.Children.Clear();
            RenderPages.Children.Add(new ElectricalTestControl());
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void OpenOptions_Click(object sender, RoutedEventArgs e)
        {
            var ventana = Window.GetWindow(this) as MainWindow;
            ventana?.MostrarOverlay(true);

            var login = new OptionsMenuWindow();
            login.Owner = ventana;
            login.ShowDialog();

            ventana?.MostrarOverlay(false);
        }
        public void MostrarOverlay(bool mostrar)
        {
            OverlayOscuro.Visibility = mostrar ? Visibility.Visible : Visibility.Collapsed;
        }

        private void BtnMainClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}