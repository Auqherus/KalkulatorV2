using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace KalkulatorV2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ekran.Text = string.Empty;
            Currentekran.Text = string.Empty;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ekran.Text = string.Empty;
            

            var button = sender as Button;

            var currentNumber = button.Name[button.Name.Length - 1];

            Currentekran.Text += currentNumber;
        }
        private void bplus_Click(object sender, RoutedEventArgs e)
        {
            var calculate = Currentekran.Text;
            if (calculate.Contains('+')){

                Currentekran.Text = Calc(calculate).ToString();
            }

            Currentekran.Text += "+";
        }

        private void bminus_Click(object sender, RoutedEventArgs e)
        {
            var calculate = Currentekran.Text;
            if (calculate.Contains('-')){

                Currentekran.Text = Calc(calculate).ToString();
            }
            Currentekran.Text += "-";
        }

        private void brazy_Click(object sender, RoutedEventArgs e)
        {
            var calculate = Currentekran.Text;
            if (calculate.Contains('*')){

                Currentekran.Text = Calc(calculate).ToString();
            }
            Currentekran.Text += "*";
        }

        private void bdivine_Click(object sender, RoutedEventArgs e)
        {

            var calculate = Currentekran.Text;
            if (calculate.Contains('/')){

                Currentekran.Text = Calc(calculate).ToString();
                
            }

           
            Currentekran.Text += "/";
        }

        private void bequal_Click(object sender, RoutedEventArgs e)
        {
            var calculate = Currentekran.Text;

            ekran.Text = Calc(calculate).ToString();

            Currentekran.Text = string.Empty;
        }

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            ekran.Text = "";


            var button = sender as Button;

            var currentNumber = button.Name[button.Name.Length - 1];

            Currentekran.Text += currentNumber;
        }

        private int Calc(string calculate)
        {
            string test = "404";
            
            if (calculate.Contains('+'))
            {
                var Numbers = calculate.Split('+');
                return int.Parse(Numbers[0]) + int.Parse(Numbers[1]);
               
            }
            if (calculate.Contains('-'))
            {
                var Numbers = calculate.Split('-');
                return int.Parse(Numbers[0]) - int.Parse(Numbers[1]);
                
            }
            if (calculate.Contains('*'))
            {
                var Numbers = calculate.Split('*');
                return int.Parse(Numbers[0]) * int.Parse(Numbers[1]);
               
            }
            if (calculate.Contains('/'))
            {
                var Numbers = calculate.Split('/');

                if (int.Parse(Numbers[1]) == 0)
                {

                    return int.Parse(test);

                }

                return int.Parse(Numbers[0]) / int.Parse(Numbers[1]);
                
 
            }
            return default;
        }
    }

    
}
