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
using System.Xml.Linq;

namespace Legpuzzel_ver1_Meindert
{
    /// <summary>
    /// Interaction logic for PuzzelScherm.xaml
    /// </summary>
    public partial class PuzzelScherm : Window
    {
        Dictionary<string, Point> correctPositions = new Dictionary<string, Point>(); //make dictionary with elements and solved positions
        Dictionary<string, bool> SolvedPieces = new Dictionary<string, bool>(); //dictionary for solved/unsolved pieces. 
        private Image[,] puzzlePieces; // Store puzzle piece images


        public PuzzelScherm(bool Goff)
        {
            InitializeComponent();
            GeneratePuzzle();
            this.Goff = Goff;
            if (Goff) { this.Geluidsknop.Style = FindResource("NoBugSoundOffStyle") as Style; }
            else { this.Geluidsknop.Style = FindResource("NoBugSoundOnStyle") as Style; }
        }
        //preparing variables
        private bool isDragging = false;
        private TranslateTransform elementTranslation = new TranslateTransform();
        private UIElement currentlyDraggedElement = null;
        bool Goff;
        bool isSoundPlaying = false;
        private void GeneratePuzzle()
        {
            // Clear the canvas
            PuzzleCanvas.Children.Clear();

            correctPositions.Clear();
            SolvedPieces.Clear();

            // Loading image
            BitmapImage sourceImage = new BitmapImage(new Uri("Pictures/Nase-zivali-kapibara-2.png", UriKind.Relative));

            int rows = 5; // Define the number of rows and columns for puzzle, later wordt dit via een variabel gedaan van ander scherm
            int columns = 5;

            double pieceWidth = sourceImage.PixelWidth / columns;
            double pieceHeight = sourceImage.PixelHeight / rows;

            puzzlePieces = new Image[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Create a CroppedBitmap to represent each puzzle piece
                    CroppedBitmap croppedPiece = new CroppedBitmap(sourceImage, new Int32Rect((int)(j * pieceWidth), (int)(i * pieceHeight), (int)pieceWidth, (int)pieceHeight));
                    Image pieceImage = new Image();
                    pieceImage.Source = croppedPiece;
                    pieceImage.Name = $"Piece_{i}_{j}";

                    // Calculate the correct position for each piece
             
                    double correctLeft = j * pieceWidth;
                    double correctTop = i * pieceHeight;

                    correctPositions.Add(pieceImage.Name, new Point(correctLeft, correctTop));


                    // Initialize the solved status
                    SolvedPieces[pieceImage.Name] = false;

                    // Set up the image's properties
                    pieceImage.Width = pieceWidth;
                    pieceImage.Height = pieceHeight;

                    // Add event handlers
                    pieceImage.MouseLeftButtonDown += DraggableElement_MouseLeftButtonDown;
                    pieceImage.MouseMove += DraggableElement_MouseMove;
                    pieceImage.MouseLeftButtonUp += DraggableElement_MouseLeftButtonUp;

                    // Add the piece to the canvas
                    Canvas.SetLeft(pieceImage, j * pieceWidth +200 );
                    Canvas.SetTop(pieceImage, i * pieceHeight);
                    pieceImage.RenderTransform = new TranslateTransform(); // Ensure the RenderTransform is set
                    PuzzleCanvas.Children.Add(pieceImage);

                    puzzlePieces[i, j] = pieceImage;
                }
            }
        }


        private void DraggableElement_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) //if click on element
        {
            isDragging = true;
            currentlyDraggedElement = (UIElement)sender;//sla op welk element deze code heeft geactiveerd in variable "element"
            if (PuzzleCanvas.Children.Contains(currentlyDraggedElement))
            {
                PuzzleCanvas.Children.Remove(currentlyDraggedElement);
                PuzzleCanvas.Children.Add(currentlyDraggedElement);
            }


        }

        private void DraggableElement_MouseMove(object sender, MouseEventArgs e)//if mouse moves while on element
        {
            if (isDragging && currentlyDraggedElement == sender)//making sure it is the actual sender, might be redundant.
            {
                //movement code
                var element = (UIElement)sender;
                Point mousePosition = Mouse.GetPosition(null);//Locate mouse within canvas

                // This sets the center of the element as the origin.
                double width = (element as FrameworkElement)?.Width ?? 0; //pak de width van element
                double height = (element as FrameworkElement)?.Height ?? 0;//same
                Canvas.SetLeft(element, mousePosition.X - width / 2);//was een bug waarbij de GetLeft niet veranderde, dit fixt het
                Canvas.SetTop(element, mousePosition.Y - height / 2);
                var elementTranslation = element.RenderTransform as TranslateTransform;
                elementTranslation.X = mousePosition.X - (Canvas.GetLeft(element) + width / 2);
                elementTranslation.Y = mousePosition.Y - (Canvas.GetTop(element) + height / 2);//to grab it at the middle
                element.RenderTransform = elementTranslation; //actually moving the element

            
                
                Point currentPosition = new Point(Canvas.GetLeft(element), Canvas.GetTop(element));//make point with current position element
                Point ElementCorrectPos = correctPositions[(element as FrameworkElement)?.Name];//grab to solving position of this specific element
                double distance = CalculateDistance(currentPosition, ElementCorrectPos);
                

              
                
            }

        }


        private void DraggableElement_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) //if left mouse button stops pressing while on element
        {
            if (!Goff && !isSoundPlaying)
            {
                SpeelGeluid();
            }
            isDragging = false;
         currentlyDraggedElement = null;
            
            var element = (UIElement)sender;
            var elementTranslation = element.RenderTransform as TranslateTransform;
            Point currentPosition = new Point(Canvas.GetLeft(element), Canvas.GetTop(element));//make point with current position element
            Point ElementCorrectPos = correctPositions[(element as FrameworkElement)?.Name];//grab to solving position of this specific element
            double distance = CalculateDistance(currentPosition, ElementCorrectPos);
            double width = (element as FrameworkElement)?.Width ?? 0; //pak de width van element


            if (distance < width/2 ) //checking if close enough to snap
            {
                elementTranslation.X = ElementCorrectPos.X - Canvas.GetLeft(element);
                elementTranslation.Y = ElementCorrectPos.Y - Canvas.GetTop(element);
                element.RenderTransform = elementTranslation;
                isDragging = false;

                element.IsHitTestVisible = false; //stay solved, can't drag the element anymore
                SolvedPieces[(element as FrameworkElement)?.Name] = true;//set solved to true in SolvedPieces directory
                bool allValuesTrue = SolvedPieces.Values.All(value => value); //check if all is solved
                if (allValuesTrue)
                {
                    // All values in the dictionary are true, so you have won
                    MessageBox.Show("Je hebt gewonnen", "Gefeliciteerd");
                }

            }

        }
        private double CalculateDistance(Point point1, Point point2) //calculating distance between the solved position and the element
        {
            double dx = point1.X - point2.X;
            double dy = point1.Y - point2.Y;
            return Math.Sqrt(dx * dx + dy * dy);//basic math
        }
        public void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Goff && !isSoundPlaying)
            {
                SpeelGeluid();
            }
            Application.Current.Shutdown();
        }

        private void Geluidsknop_Click(object sender, RoutedEventArgs e)
        {
            ToggleSoundsLocally();
            if (!Goff && !isSoundPlaying)
            {
                SpeelGeluid();
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            if (!Goff && !isSoundPlaying)
            {
                SpeelGeluid();
            }
            NaStartscherm naStartscherm = Application.Current.Windows.OfType<NaStartscherm>().FirstOrDefault();
            if (naStartscherm != null)
            {
                naStartscherm.Visibility = Visibility.Visible; //makes NaStartscherm visible again
            }
            this.Close(); // closes the current PuzzelScherm
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Set the window to fullscreen mode
            this.WindowState = WindowState.Maximized;
        }
    }
}

