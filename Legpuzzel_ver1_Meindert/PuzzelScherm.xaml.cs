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

        public PuzzelScherm()
        {
            InitializeComponent();
            correctPositions.Add("BlackElement", new Point(400, 100));
            correctPositions.Add("RedElement", new Point(400, 200));
            correctPositions.Add("YellowElement", new Point(400, 300));

        }
        private bool isDragging = false;
        private Point startPoint;
        private TranslateTransform elementTranslation = new TranslateTransform();
        private UIElement currentlyDraggedElement = null;




        private void DraggableElement_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDragging = true;
            currentlyDraggedElement = (UIElement)sender;

        }

        private void DraggableElement_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && currentlyDraggedElement == sender)
            {
                //movement code
                var element = (UIElement)sender;
                Point mousePosition = Mouse.GetPosition(PuzzleCanvas);
                var elementTranslation = element.RenderTransform as TranslateTransform;
                elementTranslation.X = mousePosition.X - 50;
                elementTranslation.Y = mousePosition.Y - 50;
                element.RenderTransform = elementTranslation;

                //check if close enough to snap
                
                Point currentPosition = new Point(elementTranslation.X,elementTranslation.Y);
                Point ElementCorrectPos = correctPositions[(element as FrameworkElement)?.Name];
                double distance = CalculateDistance(currentPosition, ElementCorrectPos);
                

                if (distance < 50)
                {
                    elementTranslation.X = ElementCorrectPos.X;
                    elementTranslation.Y = ElementCorrectPos.Y;
                    element.RenderTransform = elementTranslation;
                    isDragging = false;
                  
                    element.IsHitTestVisible = false; //stay 
                   
                }
                
            }

        }


        private void DraggableElement_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           
         isDragging = false;
         currentlyDraggedElement = null;

            
        }
        private double CalculateDistance(Point point1, Point point2)
        {
            double dx = point1.X - point2.X;
            double dy = point1.Y - point2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}

