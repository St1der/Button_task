using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Button_task
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
        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    if (e.LeftButton == MouseButtonState.Pressed) {
        Debug.Print("Left");
    }
    else {
        Debug.Print("Right");
    }
}
        private void Button_Click(object sender, RoutedEventArgs e)
        {



            Random r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),(byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            color.Background = brush;
            
            MessageBox.Show("it is your new Color");


        }
    }
}
