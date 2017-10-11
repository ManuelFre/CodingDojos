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

namespace Inhouse_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<GeoObject> Shapes = new List<GeoObject>();
        public MainWindow()
        {
            InitializeComponent();
            cboForm.ItemsSource = new List<string>() { "Rechteck", "Kreis" };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Shapes.Add(new GeoObject(
                cboForm.SelectedItem.ToString(),
                int.Parse(tboPosX.Text),
                int.Parse(tboPosY.Text),
                int.Parse(tboHeight.Text),
                int.Parse(tboWidth.Text)));
        }
    }
}
