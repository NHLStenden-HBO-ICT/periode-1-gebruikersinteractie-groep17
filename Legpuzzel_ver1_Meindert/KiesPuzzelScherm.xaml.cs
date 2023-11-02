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
        NaStartscherm nastartscherm; //vorige scherm herkenbaar maken voor dit scherm
        string PlayerName1; //strings van vorige scherm opniew aanmaken zodat dit scherm ze herkent
        string PlayerName2;

        int PuzzelGrootte;
        public KiesPuzzelScherm(NaStartscherm nss, string PlayerName1, string PlayerName2) //public kiespuzzelscherm met de waardes die doorgegeven zijn van het vorige scherm
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            nastartscherm = nss; //Dit scherm vertellen dat het vorige scherm hetzelfde scherm is als het scherm waar de waardes vandaan komen

            this.PlayerName1 = PlayerName1; //de strings die in dit scherm zijn aangemaakt worden nu gelijk gesteld aan de strings van het vorige scherm zodat c# weet dat het eigenlijk dezelfde strings zijn
            this.PlayerName2 = PlayerName2;
        }

        private void vijf_click(object sender, RoutedEventArgs e) //op welke knop er geklikt wordt bepaald de int puzzelgrootte en zet deze naar hoe groot deze moet worden in het volgende scherm.
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
                MessageBox.Show("Kies eerst een puzzelgrootte!"); // als er geen puzzelgrootte is gekozen popt deze message box op
            }
            else
            {
                KiesFotoScherm kfs = new KiesFotoScherm(this, PlayerName1, PlayerName2, PuzzelGrootte); //als er wel een grootte is gekozen wordt deze doorgegeven naar het volgende scherm
                kfs.Visibility = Visibility.Visible;                                                //samen met de playername strings en de puzzelgrootte omdat deze nodig zijn in het volgende scherm
                this.Visibility = Visibility.Hidden; //de schermen worden visible en invisible gemaakt
            }
        }
    }


}
