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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Malovani
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       static int barva = 0;

        static List<SolidColorBrush> barvy = new List<SolidColorBrush>() { Brushes.Black ,Brushes.Red, Brushes.Purple, Brushes.Pink, Brushes.HotPink, Brushes.DarkOliveGreen, Brushes.Yellow, Brushes.OrangeRed, Brushes.Black, Brushes.Red, Brushes.Purple, Brushes.Pink, Brushes.HotPink, Brushes.DarkOliveGreen, Brushes.Yellow, Brushes.OrangeRed, Brushes.Black, Brushes.Red, Brushes.Purple, Brushes.Pink, Brushes.HotPink, Brushes.DarkOliveGreen, Brushes.Yellow, Brushes.OrangeRed, Brushes.Black, Brushes.Red, Brushes.Purple, Brushes.Pink, Brushes.HotPink, Brushes.DarkOliveGreen, Brushes.Yellow, Brushes.OrangeRed, Brushes.Black, Brushes.Red, Brushes.Purple, Brushes.Pink, Brushes.HotPink, Brushes.DarkOliveGreen, Brushes.Yellow, Brushes.OrangeRed, Brushes.Black, Brushes.Red, Brushes.Purple, Brushes.Pink, Brushes.HotPink, Brushes.DarkOliveGreen, Brushes.Yellow, Brushes.OrangeRed, Brushes.Black, Brushes.Red, Brushes.Purple, Brushes.Pink, Brushes.HotPink, Brushes.DarkOliveGreen, Brushes.Yellow, Brushes.OrangeRed, Brushes.Black, Brushes.Red, Brushes.Purple, Brushes.Pink, Brushes.HotPink, Brushes.DarkOliveGreen, Brushes.Yellow, Brushes.OrangeRed, Brushes.Black, Brushes.Red, Brushes.Purple, Brushes.Pink, Brushes.HotPink, Brushes.DarkOliveGreen, Brushes.Yellow, Brushes.OrangeRed, Brushes.Black, Brushes.Red, Brushes.Purple, Brushes.Pink, Brushes.HotPink, Brushes.DarkOliveGreen, Brushes.Yellow, Brushes.OrangeRed };

        

        

        public MainWindow()
        {
            InitializeComponent();

        }

        

        void DrawCircle(Point position)
        {
            Ellipse circle = new Ellipse();
            circle.Fill = barvy[barva] ;
            circle.Stroke = barvy[barva];
            circle.StrokeThickness = 100;
            circle.Width = 100;
            circle.Height = 100;

            Canvas.SetLeft(circle, position.X);
            Canvas.SetTop(circle, position.Y);   
            

            canvas.Children.Add(circle);
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DrawCircle(e.GetPosition(canvas));
            }
            
        }

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DrawCircle(e.GetPosition(canvas));
        }

        private void canvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed) {
                barva = barva + 1;
            }
            
        }
    }
}
