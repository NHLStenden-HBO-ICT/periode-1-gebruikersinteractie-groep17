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
    /// Interaction logic for PuzzelScherm.xaml
    /// </summary>
    public partial class PuzzelScherm : Window
    {
        Dictionary<string, Point> correctPositions = new Dictionary<string, Point>(); //make dictionary with elements and solved positions
        Dictionary<string, bool> SolvedPieces = new Dictionary<string, bool>(); //dictionary for solved/unsolved pieces. 

        public PuzzelScherm()
        {
            InitializeComponent();//adding elements to the dictionaries
            correctPositions.Add("BlackElement", new Point(400, 100));//adding the solved locations
            correctPositions.Add("RedElement", new Point(400, 200));
            correctPositions.Add("YellowElement", new Point(400, 300));
            SolvedPieces["BlackElement"] = false;//adding bools wether or not the pieces are solved
            SolvedPieces["RedElement"] = false;
            SolvedPieces["YellowElement"] = false;

        }
        //preparing variables
        private bool isDragging = false;
        private TranslateTransform elementTranslation = new TranslateTransform();
        private UIElement currentlyDraggedElement = null;


        private void DraggableElement_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) //if click on element
        {
            isDragging = true;
            currentlyDraggedElement = (UIElement)sender;//sla op welk element deze code heeft geactiveerd in variable "element"

        }

        private void DraggableElement_MouseMove(object sender, MouseEventArgs e)//if mouse moves while on element
        {
            if (isDragging && currentlyDraggedElement == sender)//making sure it is the actual sender, might be redundant.
            {
                //movement code
                var element = (UIElement)sender;
                Point mousePosition = Mouse.GetPosition(PuzzleCanvas);//Locate mouse within canvas
                var elementTranslation = element.RenderTransform as TranslateTransform;
                elementTranslation.X = mousePosition.X - 50;//setting the mouse coordinates to the element
                elementTranslation.Y = mousePosition.Y - 50;//-50 to grab it at the middle
                element.RenderTransform = elementTranslation; //actually moving the element

                //check if close enough to snap
                
                Point currentPosition = new Point(elementTranslation.X,elementTranslation.Y);//make point with current position element
                Point ElementCorrectPos = correctPositions[(element as FrameworkElement)?.Name];//grab to solving position of this specific element
                double distance = CalculateDistance(currentPosition, ElementCorrectPos);
                

                if (distance < 50) //checking if close enough to snap
                {
                    elementTranslation.X = ElementCorrectPos.X;
                    elementTranslation.Y = ElementCorrectPos.Y;
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

        }


        private void DraggableElement_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) //if left mouse button stops pressing while on element
        {
           
         isDragging = false;
         currentlyDraggedElement = null;

            
        }
        private double CalculateDistance(Point point1, Point point2) //calculating distance between the solved position and the element
        {
            double dx = point1.X - point2.X;
            double dy = point1.Y - point2.Y;
            return Math.Sqrt(dx * dx + dy * dy);//basic math
        }
        public void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

