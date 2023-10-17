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
    
    public partial class MainWindow : Window
    {
        bool Moff = true;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            // When the media ends, restart it to create a looping effect
            mediaElement.Position = TimeSpan.Zero;
            mediaElement.Play();
        }
        private void MuziekKnop_Click(object sender, RoutedEventArgs e)
        {
            if (Moff) { mediaElement.Play();  MuziekKnop.Style = FindResource("NoBugMusicOnStyle") as Style;  }
            else { mediaElement.Stop(); MuziekKnop.Style = FindResource("NoBugMusicOffStyle") as Style; }
            Moff = !Moff;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
