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
        public PuzzelScherm()
        {
            InitializeComponent();
        }
        private bool isDragging = false;
        private Point startPoint;
        private TranslateTransform elementTranslation = new TranslateTransform();

        private void DraggableElement_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDragging = true;
            var element = (UIElement)sender;
            startPoint = e.GetPosition(element);
            element.CaptureMouse();
        }

        private void DraggableElement_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                var element = (UIElement)sender;
                Point mousePosition = Mouse.GetPosition(null);
                double mouseX = mousePosition.X;
                double mouseY = mousePosition.Y;
                elementTranslation.X = mousePosition.X - 75;
                elementTranslation.Y = mousePosition.Y - 75;
                element.RenderTransform = elementTranslation;

            }

        }


        private void DraggableElement_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (isDragging)
            {
                isDragging = false;
                var element = (UIElement)sender;
                element.ReleaseMouseCapture();
            }
        }
    }
}

