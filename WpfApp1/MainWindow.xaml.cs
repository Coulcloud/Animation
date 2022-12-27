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
using System.Windows.Media.Animation;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DoubleAnimation buttAnim = new DoubleAnimation();
            
        }
        SolidColorBrush myAnimatedBrush = new SolidColorBrush();
        Storyboard myStoryboard;
        private void Anim(object sender)
        {
            Rectangle Rec = (Rectangle)sender;
            Rec.Fill = myAnimatedBrush;

            myStoryboard = new Storyboard();
            ColorAnimation myColorAnimation = new ColorAnimation();
            myColorAnimation.From = Colors.White;
            myColorAnimation.To = Colors.Red;
            myColorAnimation.AutoReverse = true;
            myColorAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            myStoryboard.Children.Add(myColorAnimation);
            Storyboard.SetTargetName(myColorAnimation, "MyAnimatedBrush");
            Storyboard.SetTargetProperty(myColorAnimation, new PropertyPath(SolidColorBrush.ColorProperty));
            //myStoryboard.Begin(this);
        }

        private void gooo_Click(object sender, RoutedEventArgs e)
        {
            Anim(myRectangle);
        }
    }
}
