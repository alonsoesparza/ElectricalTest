using ElectricalTest.Wndow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ElectricalTest.UsrControl
{
    /// <summary>
    /// Interaction logic for ElectricalTestControl.xaml
    /// </summary>
    public partial class ElectricalTestControl : UserControl
    {
        public ElectricalTestControl()
        {
            InitializeComponent();
        }

        private void BtnModelPause_Click(object sender, RoutedEventArgs e)
        {
            var ventana = Window.GetWindow(this) as MainWindow;
            ventana?.MostrarOverlay(true);

            var login = new ModelPauseWindow();
            login.Owner = ventana;
            login.ShowDialog();

            ventana?.MostrarOverlay(false);
        }

        private void BtnCleanCodeTextbox_Click(object sender, RoutedEventArgs e)
        {
            TxtCode.Clear();
            TxtCode.Focus();
        }

        private void BtnCleanTMCutLabelTextbox_Click(object sender, RoutedEventArgs e)
        {
            TxtTMCutLabel.Clear();
            TxtTMCutLabel.Focus();
        }
    }
}
