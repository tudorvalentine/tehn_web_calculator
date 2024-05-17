using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsCalculator
{
    public partial class Default : Page
    {
        private static string _input = string.Empty;
        private static string _operator = string.Empty;
        private static double _result = 0;
        private static double _memory = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                string value = button.Text;

                if ("0123456789.".Contains(value))
                {
                    if (value == "." && _input.Contains(".")) return;
                    _input += value;
                    txtDisplay.Text = _input;
                }
                else
                {
                    if (!string.IsNullOrEmpty(_input))
                    {
                        _result = double.Parse(_input);
                        _input = string.Empty;
                    }
                    _operator = value;
                }
            }
        }

        protected void ClearDisplay(object sender, EventArgs e)
        {
            _input = string.Empty;
            _operator = string.Empty;
            _result = 0;
            txtDisplay.Text = string.Empty;
        }

        protected void Evaluate(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_input))
            {
                double secondNumber = double.Parse(_input);
                switch (_operator)
                {
                    case "+":
                        _result += secondNumber;
                        break;
                    case "-":
                        _result -= secondNumber;
                        break;
                    case "×":
                        _result *= secondNumber;
                        break;
                    case "÷":
                        if (secondNumber != 0)
                            _result /= secondNumber;
                        break;
                }
                txtDisplay.Text = _result.ToString();
                _input = _result.ToString();
                _operator = string.Empty;
            }
        }

        protected void MemoryClear(object sender, EventArgs e)
        {
            _memory = 0;
        }

        protected void MemoryRecall(object sender, EventArgs e)
        {
            txtDisplay.Text = _memory.ToString();
            _input = _memory.ToString();
        }

        protected void MemoryPlus(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double value))
            {
                _memory += value;
            }
        }

        protected void MemoryMinus(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double value))
            {
                _memory -= value;
            }
        }

        protected void SquareValue(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double value))
            {
                _result = Math.Pow(value, 2);
                txtDisplay.Text = _result.ToString();
            }
        }

        protected void CubeValue(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double value))
            {
                _result = Math.Pow(value, 3);
                txtDisplay.Text = _result.ToString();
            }
        }

        protected void ExpValue(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double value))
            {
                _result = Math.Exp(value);
                txtDisplay.Text = _result.ToString();
            }
        }
        protected void SqrtValue(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double value))
            {
                _result = Math.Sqrt(value);
                txtDisplay.Text = _result.ToString();
            }
        }

        protected void LogValue(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double value))
            {
                _result = Math.Log10(value);
                txtDisplay.Text = _result.ToString();
            }
        }

        protected void LnValue(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double value))
            {
                _result = Math.Log(value);
                txtDisplay.Text = _result.ToString();
            }
        }
        protected void FactorialValue(object sender, EventArgs e)
        {
            if (int.TryParse(txtDisplay.Text, out int value))
            {
                if (value < 0)
                {
                    txtDisplay.Text = "Error";
                }
                else
                {
                    _result = Factorial(value);
                    txtDisplay.Text = _result.ToString();
                }
            }
        }

        public static long Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

    }
}
