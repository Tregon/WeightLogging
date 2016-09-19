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

namespace WeightLogging
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
        private string BackupFile;
        private string CompanyID;
        private List<string> UnsentRows;

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string savestring = string.Empty;
            

            UnsentRows.Add(savestring);

        }

        private void SendProcess()
        {

        }
        private void btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            textBox_Code.Text = string.Empty;
            textBox_Weight.Text = string.Empty;
        }
    }
}
