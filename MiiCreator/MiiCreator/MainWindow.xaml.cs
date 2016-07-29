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

namespace MiiCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EarColorRedButton(object sender, RoutedEventArgs e)
        {
            
            LeftEar.Fill = new SolidColorBrush(Colors.Red);
            RightEar.Fill = new SolidColorBrush(Colors.Red);
            //LeftEar.Stroke = "FireBrick";

        }

        private void EarColorBlueButton(object sender, RoutedEventArgs e)
        {
            LeftEar.Fill = new SolidColorBrush(Colors.Blue);
            RightEar.Fill = new SolidColorBrush(Colors.Blue);
        }

        private void WhiteNoseButton(object sender, RoutedEventArgs e)
        {
           Nose.Fill = new SolidColorBrush(Colors.White);
        }

        private void GreenEyesButton(object sender, RoutedEventArgs e)
        {
            RightEye.Fill = new SolidColorBrush(Colors.Green);
            LeftEye.Fill = new SolidColorBrush(Colors.Green);
        }

        private void BlueNoseButton(object sender, RoutedEventArgs e)
        {
            Nose.Fill = new SolidColorBrush(Colors.Blue);
        }

        private void WhiteEyesButton(object sender, RoutedEventArgs e)
        {
            RightEye.Fill = new SolidColorBrush(Colors.White);
            LeftEye.Fill = new SolidColorBrush(Colors.White);
        }
        private void RedHead(object sender, RoutedEventArgs e)
        {
            Face.Fill = new SolidColorBrush(Colors.Red);
        }

        private void BlueHead(object sender, RoutedEventArgs e)
        {
            Face.Fill = new SolidColorBrush(Colors.Blue);
        }

        private void Rectangle_Mouth_Click(object sender, RoutedEventArgs e)
        {
           //Mouth = Converter<Ellipse, Rectangle>;
        }

        private void Face_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void NoseSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
