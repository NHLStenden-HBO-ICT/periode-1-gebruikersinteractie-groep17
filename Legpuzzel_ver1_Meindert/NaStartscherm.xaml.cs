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
        public NaStartscherm()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }
        bool Moff;
        public string PlayerName1 { get; set; }
        public string PlayerName2 { get; set; }
        bool Goff;
        bool isSoundPlaying = false;
        public NaStartscherm(StartScherm ss, bool Moff, bool Goff)
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            startscherm = ss;

            this.Moff = Moff;
            if (Moff) { this.MuziekKnop.Style = FindResource("NoBugMusicOffStyle") as Style; }
            else {  this.MuziekKnop.Style = FindResource("NoBugMusicOnStyle") as Style; }
            this.Goff = Goff;
            if (Goff) { this.Geluidsknop.Style = FindResource("NoBugSoundOffStyle") as Style; }
            else { this.Geluidsknop.Style = FindResource("NoBugSoundOnStyle") as Style; }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Goff && !isSoundPlaying)
            {
                // Play the sound and handle MediaEnded event
                ButtonSound.Position = TimeSpan.Zero;
                ButtonSound.Play();
                isSoundPlaying = true;
                ButtonSound.MediaEnded += (s, args) => isSoundPlaying = false;
            }
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
            PuzzelScherm ps = new PuzzelScherm(Goff);
            ps.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Goff && !isSoundPlaying)
            {
                SpeelGeluid();
            }
            Application.Current.Shutdown();

        }

        private void BackArrow_Click(object sender, RoutedEventArgs e)
        {
            if (!Goff && !isSoundPlaying)
            {
                SpeelGeluid();
            }
            startscherm.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
            
        }
        private void MuziekKnop_Click(object sender, RoutedEventArgs e)
        {
            if (!Goff && !isSoundPlaying)
            {
                SpeelGeluid();
            }
            startscherm.ToggleMusicLocally();
            PublicSwitch();
            
            if (Moff) { this.MuziekKnop.Style = FindResource("NoBugMusicOffStyle") as Style; }
            else { this.MuziekKnop.Style = FindResource("NoBugMusicOnStyle") as Style; }


        }

        private void Geluidsknop_Click(object sender, RoutedEventArgs e)
        {

            startscherm.ToggleSoundsLocally();
            PublicSoundSwitch();

            if (Goff) { this.Geluidsknop.Style = FindResource("NoBugSoundOffStyle") as Style; }
            else { this.Geluidsknop.Style = FindResource("NoBugSoundOnStyle") as Style; }
            if (!Goff && !isSoundPlaying)
            {
                SpeelGeluid();
            }

        }
        public void PublicSwitch()
        {
            Moff = !Moff;
        }

        public void PublicSoundSwitch()
        {
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
