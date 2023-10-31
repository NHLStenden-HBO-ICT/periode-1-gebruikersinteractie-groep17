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
    /// Interaction logic for KiesPuzzelScherm.xaml
    /// </summary>
    public partial class KiesPuzzelScherm : Window
    {
        NaStartscherm nastartscherm;
        string PlayerName1;
        string PlayerName2;

        int PuzzelGrootte;
        public KiesPuzzelScherm(NaStartscherm nss, string PlayerName1, string PlayerName2)
        {
            InitializeComponent();
            nastartscherm = nss;

            this.PlayerName1 = PlayerName1;
            this.PlayerName2 = PlayerName2;
        }

        private void vijf_click(object sender, RoutedEventArgs e)
        {
            PuzzelGrootte = 5;
        }

        private void zes_click(object sender, RoutedEventArgs e)
        {
            PuzzelGrootte = 6;
        }

        private void zeven_click(object sender, RoutedEventArgs e)
        {
            PuzzelGrootte = 7;
        }

        private void acht_click(object sender, RoutedEventArgs e)
        {
            PuzzelGrootte = 8;
        }

        private void negen_click(object sender, RoutedEventArgs e)
        {
            PuzzelGrootte = 9;
        }

        private void tien_click(object sender, RoutedEventArgs e)
        {
            PuzzelGrootte = 10;
        }

        private void start_click(object sender, RoutedEventArgs e)
        {
            if (PuzzelGrootte == 0)
            {
                MessageBox.Show("Kies eerst een puzzelgrootte!");
            }
            else
            {
                PuzzelScherm ps = new PuzzelScherm(this, PlayerName1, PlayerName2, PuzzelGrootte);
                ps.Visibility = Visibility.Visible;
                this.Visibility = Visibility.Hidden;
            }
        }
    }


}
