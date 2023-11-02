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
    /// Interaction logic for KiesFotoScherm.xaml
    /// </summary>
    public partial class KiesFotoScherm : Window
    {
        KiesPuzzelScherm kiespuzzelscherm;
        string PlayerName1;
        string PlayerName2;
        int PuzzelGrootte;
        int PuzzelKeuze = 0;
        private bool isSelected = false;
        public KiesFotoScherm(KiesPuzzelScherm kps, string PlayerName1, string PlayerName2, int PuzzelGrootte)
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            this.PlayerName1 = PlayerName1;
            this.PlayerName2 = PlayerName2;
            this.PuzzelGrootte = PuzzelGrootte;
            kiespuzzelscherm = kps;
        }

        private void Foto1_click(object sender, RoutedEventArgs e)
        {
            PuzzelKeuze = 1;

            isSelected = !isSelected;

            if (isSelected)
            {
                KiesFoto1.BorderBrush = Brushes.Red;
                KiesFoto1.BorderThickness = new Thickness(3);
            }else
            {
                KiesFoto1.BorderBrush = null;
                KiesFoto1.BorderThickness = new Thickness(0);
            }
        }

        private void Foto2_click(object sender, RoutedEventArgs e)
        {
            PuzzelKeuze = 2;

            isSelected = !isSelected;

            if (isSelected)
            {
                KiesFoto2.BorderBrush = Brushes.Red;
                KiesFoto2.BorderThickness = new Thickness(3);
            }
            else
            {
                KiesFoto2.BorderBrush = null;
                KiesFoto2.BorderThickness = new Thickness(0);
            }
        }
        private void Foto3_click(object sender, RoutedEventArgs e)
        {
            PuzzelKeuze = 3;

            isSelected = !isSelected;

            if (isSelected)
            {
                KiesFoto3.BorderBrush = Brushes.Red;
                KiesFoto3.BorderThickness = new Thickness(3);
            }
            else
            {
                KiesFoto3.BorderBrush = null;
                KiesFoto3.BorderThickness = new Thickness(0);
            }
        }
   

        private void start_click(object sender, RoutedEventArgs e)
        {
            if (PuzzelKeuze == 0)
            {
                MessageBox.Show("Kies eerst een puzzel!");
            }
            else
            {
                PuzzelScherm ps = new PuzzelScherm(this, PlayerName1, PlayerName2, PuzzelGrootte, PuzzelKeuze);
                ps.Visibility = Visibility.Visible;
                this.Visibility = Visibility.Hidden;
            }
        }
       
    }
}
