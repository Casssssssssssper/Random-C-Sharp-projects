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

namespace Science_Calculator
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

       
            int resultValue = 0;
            String operationPerformed = "";
            bool isOperationPerformed = false;
           

            private void button_click(object sender, EventArgs e)
            {
                if ((textBox_Result.Text == "0") || (isOperationPerformed))
                    textBox_Result.Clear();

                isOperationPerformed = false;
                Button button = (Button)sender;
                if (button.Text == ".")
                {
                    if (!textBox_Result.Text.Contains("."))
                        textBox_Result.Text = textBox_Result.Text + button.Text;

                }
                else
                    textBox_Result.Text = textBox_Result.Text + button.Text;


            }

            private void operator_click(object sender, EventArgs e)
            {
                Button button = (Button)sender;

                if (resultValue != 0)
                {
                    button15.PerformClick();
                    operationPerformed = button.Text;
                    labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                    isOperationPerformed = true;
                }
                else
                {

                    operationPerformed = button.Text;
                    resultValue = Double.Parse(textBox_Result.Text);
                    labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                    isOperationPerformed = true;
                }
            }

            private void button4_Click(object sender, EventArgs e)
            {
                textBox_Result.Text = "0";
            }

            private void button5_Click(object sender, EventArgs e)
            {
                textBox_Result.Text = "0";
                resultValue = 0;
            }

            private void button15_Click(object sender, EventArgs e)
            {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;

                //case "+":
                //    textBox1.Text = (num1 + num2).ToString();
                //    break;
                //case "-":
                //    textBox1.Text = (num1 - num2).ToString();
                //    break;
                //case "*":
                //    textBox1.Text = (num1 * num2).ToString();
                //    break;
                //case "/":
                //    textBox1.Text = (num1 / num2).ToString();
                //    break;
                //case "^":
                //    textBox1.Text = (int.Parse(num1.ToString()) ^ int.Parse(num2.ToString())).ToString();
                //    break;
                //case "%":
                //    textBox1.Text = (num1 % num2).ToString();
                //    break;
            }
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = "";
            }
       
    }
}
