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
            if (WhatOperation(calculate))
            {

                Currentekran.Text = Calc(calculate).ToString();
            }

            Currentekran.Text += "+";
        }

        private void bminus_Click(object sender, RoutedEventArgs e)
        {
            var calculate = Currentekran.Text;
            if (WhatOperation(calculate))
            {

                Currentekran.Text = Calc(calculate).ToString();
            }
            Currentekran.Text += "-";
        }

        private void brazy_Click(object sender, RoutedEventArgs e)
        {
            var calculate = Currentekran.Text;
            if (WhatOperation(calculate))
            {

                Currentekran.Text = Calc(calculate).ToString();
            }
            Currentekran.Text += "*";
        }

        private void bdivine_Click(object sender, RoutedEventArgs e)
        { 
            var calculate = Currentekran.Text;
            var Numbers = calculate.Split('/');

            if (WhatOperation(calculate))
            {
               
                if (int.Parse(Numbers[1]) == 0)
                {
                    ekran.Text = "Nie dziel przez zero!";

                    
                }
                else
                {
                    int resoult = int.Parse(Numbers[0]) / int.Parse(Numbers[1]);
                    Currentekran.Text = resoult.ToString();
                    ekran.Text = "";
                }

                 
            }
            
            Currentekran.Text += "/";

        }

        private void bequal_Click(object sender, RoutedEventArgs e)
        {
            var calculate = Currentekran.Text;
            
            if (WhatOperation(calculate))
            {


                ekran.Text = Calc(calculate).ToString();
            }

            Currentekran.Text = string.Empty;
        }

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            ekran.Text = "";


            var button = sender as Button;

            var currentNumber = button.Name[button.Name.Length - 1];

            Currentekran.Text += currentNumber;
        }

        private bool WhatOperation(string calculate)
            => calculate.Contains('+') || calculate.Contains('-') || calculate.Contains('*')
            || calculate.Contains('/');

        private int Calc(string calculate)
        {
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




            return 404;
        }

        private void Dziel()
        {
            string wyjatek = "";

        }

    }


}
