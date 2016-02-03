namespace SimpleCalculator
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Controls;
    using System.Threading;

    public partial class MainWindow : Window
    {
        private decimal firstNumber = decimal.Zero;
        private decimal secondNumber = decimal.Zero;
        private char operatorType = '0';
        private bool iSOperatorClicked = false;

        public MainWindow()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Constants.SpecificCulture);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (iSOperatorClicked)
            {
                TextBoxDisplay.Clear();
            }

            Button btn = (Button)sender;
            if (TextBoxDisplay.Text == Constants.ZeroChar)
            {
                TextBoxDisplay.Clear();
            }
            TextBoxDisplay.Text += btn.Content;
            iSOperatorClicked = false;
        }

        private void BackspaceButton_Click(object sender, RoutedEventArgs e)
        {
            int length = TextBoxDisplay.Text.Length;

            if (!string.IsNullOrEmpty(TextBoxDisplay.Text) && TextBoxDisplay.Text != Constants.ZeroChar)
            {
                TextBoxDisplay.Text = TextBoxDisplay.Text.Remove(length - 1, 1);
                length = TextBoxDisplay.Text.Length;
                if (length == 0)
                {
                    TextBoxDisplay.Text = Constants.ZeroChar;
                }
            }
        }

        private void DotButton_Click(object sender, RoutedEventArgs e)
        {
            if (!TextBoxDisplay.Text.Contains(Constants.DotChar))
            {
                TextBoxDisplay.Text += Constants.DotChar;
            }
        }

        private void PlusMinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (!TextBoxDisplay.Text.Contains(Constants.MinusChar))
            {
                TextBoxDisplay.Text = Constants.MinusChar + TextBoxDisplay.Text;
            }
            else
            {
                TextBoxDisplay.Text = TextBoxDisplay.Text.Trim(char.Parse(Constants.MinusChar));
            }
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                iSOperatorClicked = true;
                Button btn = (Button)sender;
                firstNumber = decimal.Parse(TextBoxDisplay.Text, NumberStyles.AllowLeadingSign |
                                            NumberStyles.AllowDecimalPoint |
                                            NumberStyles.AllowExponent);
                operatorType = Convert.ToChar(btn.Content);
            }
            catch (Exception)
            {
                TextBoxDisplay.Text = Constants.ErrorStr;
            }
        }

        private void SqrtButton_Click(object sender, RoutedEventArgs e)
        {
            iSOperatorClicked = true;
            double result = Math.Sqrt(Convert.ToDouble(TextBoxDisplay.Text));
            PrintResultNumber((decimal)result);
        }

        private void ReciprocButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                iSOperatorClicked = true;
                firstNumber = decimal.Parse(TextBoxDisplay.Text, 
                                            NumberStyles.AllowLeadingSign | 
                                            NumberStyles.AllowDecimalPoint |
                                            NumberStyles.AllowExponent);
                decimal result = 1 / firstNumber;
                PrintResultNumber(result);
            }
            catch (OverflowException)
            {
                TextBoxDisplay.Text = Constants.ErrorStr;
            }
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            iSOperatorClicked = true;
            decimal result = decimal.Zero;
            try
            {
                secondNumber = decimal.Parse(TextBoxDisplay.Text, 
                                             NumberStyles.AllowLeadingSign | 
                                             NumberStyles.AllowDecimalPoint |
                                             NumberStyles.AllowExponent);
                switch (operatorType)
                {
                    case Constants.Subtraction:
                        result = firstNumber - secondNumber;
                        break;
                    case Constants.Add:
                        result = firstNumber + secondNumber;
                        break;
                    case Constants.Division:
                        result = firstNumber / secondNumber;
                        break;
                    case Constants.Multiplication:
                        result = firstNumber * secondNumber;
                        break;
                    case Constants.Percent:
                        result = (firstNumber / secondNumber) * 100;
                        break;
                    default:
                        break;
                }

                PrintResultNumber(result);
            }
            catch (OverflowException)
            {
                TextBoxDisplay.Text = Constants.ErrorStr;
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = decimal.Zero;
            secondNumber = decimal.Zero;
            operatorType = '0';
            iSOperatorClicked = false;
            TextBoxDisplay.Text = Constants.ZeroChar;
        }

        private void PrintResultNumber(decimal result)
        {
            string[] resultStr = result.ToString().Split(char.Parse(Constants.DotChar));
            int decimalPlaces = 0;
            if (resultStr.Length > 1)
            {
                decimalPlaces = resultStr[1].Length;
            }

            if (decimalPlaces > 15)
            {
                TextBoxDisplay.Text = string.Format("{0:0.00}", result.ToString("E15"));
            }
            else
            {
                TextBoxDisplay.Text = string.Format("{0:0.00}", result.ToString());
            }
        }
    }
}
