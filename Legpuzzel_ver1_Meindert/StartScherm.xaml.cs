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
using System.Windows.Media.Animation;
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
        public bool Goff = true;
        private bool isSoundPlaying = false;
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
            if (!Goff && !isSoundPlaying)
            {
                SpeelGeluid();
            }
        }
        private void Geluidsknop_Click(object sender, RoutedEventArgs e)
        {
            ToggleSoundsLocally();
            if (!Goff && !isSoundPlaying)
            {
                SpeelGeluid();
            }
        }

        public void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Goff && !isSoundPlaying)
            {
                SpeelGeluid();
            }
            Application.Current.Shutdown();
        }

        public void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Goff && !isSoundPlaying)
            {
                SpeelGeluid();
            }
            NaStartscherm sc = new NaStartscherm(this, Moff, Goff);
            sc.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }


        public void ToggleMusicLocally()
        {
            if (Moff) { this.mediaElement.Play(); MuziekKnop.Style = FindResource("NoBugMusicOnStyle") as Style; }
            else { this.mediaElement.Stop(); MuziekKnop.Style = FindResource("NoBugMusicOffStyle") as Style; }
            Moff = !Moff;


        }

        public void ToggleSoundsLocally()
        {
            if (Goff) { Geluidsknop.Style = FindResource("NoBugSoundOnStyle") as Style; }
            else { Geluidsknop.Style = FindResource("NoBugSoundOffStyle") as Style; }
            Goff = !Goff;


        }
        public void SpeelGeluid()
        {
            ButtonSound.Position = TimeSpan.Zero;
            ButtonSound.Play();
            isSoundPlaying = true;
            ButtonSound.MediaEnded += (s, args) => isSoundPlaying = false;
        }
        private void ButtonSound_MediaEnded(object sender, RoutedEventArgs e)
        {
            isSoundPlaying = false;
            ButtonSound.MediaEnded -= ButtonSound_MediaEnded;
        }


    }
}
