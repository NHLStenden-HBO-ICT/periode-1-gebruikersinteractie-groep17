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
        StartScherm startscherm;
        bool Moff;
        bool Goff;
        public string PlayerName1 { get; set; }
        public string PlayerName2 { get; set; }
        public NaStartscherm(StartScherm ss, bool Moff, bool Goff)
        {
            InitializeComponent();
            startscherm = ss;

            this.Moff = Moff;
            if (Moff) { this.MuziekKnop.Style = FindResource("NoBugMusicOffStyle") as Style; }
            else {  this.MuziekKnop.Style = FindResource("NoBugMusicOnStyle") as Style; }
            this.Goff = Goff;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            PlayerName1 = txtPlayerName1.Text;
            PlayerName2 = txtPlayerName2.Text;
            
            if (string.IsNullOrEmpty(PlayerName1))
            {
                PlayerName1 = "Speler 1";
            }
            if (string.IsNullOrEmpty(PlayerName2))
            {
                PlayerName2 = "Speler 2";
            }
            PuzzelScherm ps = new PuzzelScherm();
            ps.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BackArrow_Click(object sender, RoutedEventArgs e)
        {
            //StartScherm sc = new StartScherm();
           
            startscherm.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
            
        }
        private void MuziekKnop_Click(object sender, RoutedEventArgs e)
        {

            startscherm.ToggleMusicLocally();
            PublicSwitch();
            
            if (Moff) { this.MuziekKnop.Style = FindResource("NoBugMusicOffStyle") as Style; }
            else { this.MuziekKnop.Style = FindResource("NoBugMusicOnStyle") as Style; }


        }
        public void PublicSwitch()
        {
            Moff = !Moff;
        }
    }
}
