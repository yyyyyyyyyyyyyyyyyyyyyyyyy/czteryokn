using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace czteryokn
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetImage("https://a.allegroimg.com/original/1e3cd1/effa2eb94364be1182baa17cce08/10-zl-MIESZKO-I-1994-AA-0042-DO-WYBORU-PACZKI-TDLR");
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (toggleButton1.IsChecked == true)
            {
                SetImage("https://upload.wikimedia.org/wikipedia/commons/7/7d/National_Flag_of_Poland.png");
            }
            else
            {
                SetImage("https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Flag_of_Indonesia.svg/1280px-Flag_of_Indonesia.svg.png");
            }
        }

        private void SetImage(string imageUrl)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(imageUrl);
            bitmapImage.EndInit();

            image.Source = bitmapImage;
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            textBlock2.Text = $"{radioButton.Content}";
            switch (radioButton.Content.ToString())
            {
                case "zielony":
                    textBlock2.Foreground = System.Windows.Media.Brushes.Red;
                    break;
                case "niebieski":
                    textBlock2.Foreground = System.Windows.Media.Brushes.Green;
                    break;
                case "czerwony":
                    textBlock2.Foreground = System.Windows.Media.Brushes.Blue;
                    break;
            }
        }
    }
}