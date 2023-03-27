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
using static System.Net.Mime.MediaTypeNames;

namespace WpfImage
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            ImageStretch = Stretch.Fill;
        }


        public Stretch ImageStretch
        {
            get { return (Stretch)GetValue(ImageStretchProperty); }
            set { SetValue(ImageStretchProperty, value); }
        }

        public static readonly DependencyProperty ImageStretchProperty = DependencyProperty.Register("ImageStretch", typeof(Stretch), typeof(MainWindow));


        private void LengthSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MyImage.Height = e.NewValue;
        }

        private void WidthSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MyImage.Width = e.NewValue;
        }

        private void chkBox_Clicked(object sender, RoutedEventArgs e)
        {
            if (chkBox.IsChecked == true)
            {
                ImageStretch = Stretch.Uniform;
                LengthSlider.SetBinding(Slider.ValueProperty, new Binding("Value") { ElementName = "WidthSlider", Mode = BindingMode.TwoWay });
            }

        }

        private void chkBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }


}
