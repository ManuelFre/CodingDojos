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

namespace Studentenverwaltung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> studyList = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSaveStudy_Click(object sender, RoutedEventArgs e)
        {
            studyList.Add(TboStudy.Text);
            updateStudyList(studyList);
            
        }

        private void updateStudyList(List<string> studyList)
        {
            DgrStudy.ItemsSource = null;
            DgrStudy.ItemsSource = studyList;
            CboStudy.ItemsSource =null;
            CboStudy.ItemsSource = studyList;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
