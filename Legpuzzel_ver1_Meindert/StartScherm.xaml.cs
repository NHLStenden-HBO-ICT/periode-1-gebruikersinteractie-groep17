using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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


namespace Legpuzzel_ver1_Meindert
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
  

    public partial class StartScherm : Window
    {
       
        public bool Moff = true;
        public StartScherm()
        {
            InitializeComponent();
        
        }
        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            
            mediaElement.Position = TimeSpan.Zero;
            mediaElement.Play();
        }
        private void MuziekKnop_Click(object sender, RoutedEventArgs e)
        {
            ToggleMusicLocally();


        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            NaStartscherm sc = new NaStartscherm(this, Moff);
            sc.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;
        }


        public void ToggleMusicLocally()
        {
            if (Moff) { this.mediaElement.Play(); }
            else { this.mediaElement.Stop(); }
            if (Moff) { MuziekKnop.Style = FindResource("NoBugMusicOnStyle") as Style; }
            else { MuziekKnop.Style = FindResource("NoBugMusicOffStyle") as Style; }

            Moff = !Moff;
        }
    } 
}
