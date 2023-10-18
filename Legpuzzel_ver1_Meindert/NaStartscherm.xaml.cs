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
using System.Windows.Shapes;

namespace Legpuzzel_ver1_Meindert
{
    /// <summary>
    /// Interaction logic for NaStartscherm.xaml
    /// </summary>
    public partial class NaStartscherm : Window
    {
        public string PlayerName1 { get; set; }
        public NaStartscherm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            PlayerName1 = txtPlayerName1.Text;
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BackArrow_Click(object sender, RoutedEventArgs e)
        {
            StartScherm sc = new StartScherm();
            sc.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
            
        }
    }
}
