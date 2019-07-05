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


            string[] operators; // Stack for Operators
            string[] tokens; // Array
            string[] output; // Output = Queue

            int testValue = 0;
            String operationPerformed = "";
            bool isOperationPerformed = false;
        }

        // While there are tokens to read, read token
        // if its a number add it to the queue
        // if its an operator:
        // while there is an operator on top of the stack with freater proecedence:
        // pop operators from the stack ontop of the output queue
        // push the current operator onto the stack
        // if its a left bracket push it at the top of the stack
        // if its a left bracket
        // while there is not a left bracket at the top of the stack
        // Pop operators from the stack onto the output queue
        // Pop he left bracket from the stack but discard it
        // while there is operators on the stack, pop them to the queue




        // https://www.youtube.com/watch?v=QzVVjboyb0s





       

        


        //private void button_click(object sender, EventArgs e)
        //{
        //    if ((textBox_Result.Text == "0") || (isOperationPerformed))
        //        textBox_Result.Clear();

        //    isOperationPerformed = false;
        //    Button button = (Button)sender;
        //    if (button.Text == ".")
        //    {
        //        if (!textBox_Result.Text.Contains("."))
        //            textBox_Result.Text = textBox_Result.Text + button.Text;

        //    }
        //    else
        //        textBox_Result.Text = textBox_Result.Text + button.Text;


        //}

        //private void operator_click(object sender, EventArgs e)
        //{
        //    Button button = (Button)sender;

        //    if (resultValue != 0)
        //    {
        //        button15.PerformClick();
        //        operationPerformed = button.Text;
        //        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
        //        isOperationPerformed = true;
        //    }
        //    else
        //    {

        //        operationPerformed = button.Text;
        //        resultValue = Double.Parse(textBox_Result.Text);
        //        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
        //        isOperationPerformed = true;
        //    }
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    textBox_Result.Text = "0";
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    textBox_Result.Text = "0";
        //    resultValue = 0;
        //}

        //private void button15_Click(object sender, EventArgs e)
        //{
        //switch (operationPerformed)
        //{
        //    case "+":
        //        textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
        //        break;
        //    case "-":
        //        textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
        //        break;
        //    case "*":
        //        textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
        //        break;
        //    case "/":
        //        textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
        //        break;
        //    default:
        //        break;

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




        //    decimal num1;
        //    decimal num2;
        //    string operation;
        //    public Form1()
        //    {
        //        InitializeComponent();
        //    }
        //    private void input(string a)
        //    {
        //        if (textBox1.Text == "0")
        //            textBox1.Text = a;
        //        else
        //            textBox1.Text += a;
        //    }

        //    private void Form1_Load(object sender, EventArgs e)
        //    {

        //    }

        //    private void button2_Click(object sender, EventArgs e)
        //    {
        //        input("1");
        //    }

        //    private void button3_Click(object sender, EventArgs e)
        //    {
        //        input("2");
        //    }

        //    private void button4_Click(object sender, EventArgs e)
        //    {
        //        input("3");
        //    }

        //    private void button5_Click(object sender, EventArgs e)
        //    {
        //        input("4");
        //    }

        //    private void button6_Click(object sender, EventArgs e)
        //    {
        //        input("5");
        //    }

        //    private void button7_Click(object sender, EventArgs e)
        //    {
        //        input("6");
        //    }

        //    private void button8_Click(object sender, EventArgs e)
        //    {
        //        input("7");
        //    }

        //    private void button9_Click(object sender, EventArgs e)
        //    {
        //        input("8");
        //    }

        //    private void button10_Click(object sender, EventArgs e)
        //    {
        //        input("9");
        //    }

        //    private void button1_Click(object sender, EventArgs e)
        //    {
        //        input("0");
        //    }

        //    private void button11_Click(object sender, EventArgs e)
        //    {
        //        textBox1.Text += ".";
        //    }

        //    private void button24_Click(object sender, EventArgs e)
        //    {
        //        num2 = decimal.Parse(textBox1.Text);
        //        ////////////////////////////////
        //        switch (operation)
        //        {
        //            case "+":
        //                textBox1.Text = (num1 + num2).ToString();
        //                break;
        //            case "-":
        //                textBox1.Text = (num1 - num2).ToString();
        //                break;
        //            case "*":
        //                textBox1.Text = (num1 * num2).ToString();
        //                break;
        //            case "/":
        //                textBox1.Text = (num1 / num2).ToString();
        //                break;
        //            case "^":
        //                textBox1.Text = (int.Parse(num1.ToString()) ^ int.Parse(num2.ToString())).ToString();
        //                break;
        //            case "%":
        //                textBox1.Text = (num1 % num2).ToString();
        //                break;
        //        }
        //    }

        //    private void button12_Click(object sender, EventArgs e)
        //    {
        //        num1 = decimal.Parse(textBox1.Text);
        //        operation = "+";
        //        textBox1.Text = "0";
        //    }

        //    private void button13_Click(object sender, EventArgs e)
        //    {
        //        num1 = decimal.Parse(textBox1.Text);
        //        operation = "-";
        //        textBox1.Text = "0";
        //    }

        //    private void button14_Click(object sender, EventArgs e)
        //    {
        //        num1 = decimal.Parse(textBox1.Text);
        //        operation = "/";
        //        textBox1.Text = "0";
        //    }

        //    private void button15_Click(object sender, EventArgs e)
        //    {
        //        num1 = decimal.Parse(textBox1.Text);
        //        operation = "*";
        //        textBox1.Text = "0";
        //    }

        //    private void button25_Click(object sender, EventArgs e)
        //    {
        //        textBox1.Text = "0";
        //    }

        //    private void button16_Click(object sender, EventArgs e)
        //    {
        //        textBox1.Text = (Math.Sin(double.Parse(textBox1.Text))).ToString();
        //    }

        //    private void button17_Click(object sender, EventArgs e)
        //    {
        //        textBox1.Text = (Math.Cos(double.Parse(textBox1.Text))).ToString();
        //    }

        //    private void button19_Click(object sender, EventArgs e)
        //    {
        //        long f = 1;
        //        for (long i = 1; i <= long.Parse(textBox1.Text); i++)
        //        {
        //            f = f * i;
        //        }
        //        textBox1.Text = f.ToString();
        //    }

        //    private void button20_Click(object sender, EventArgs e)
        //    {
        //        textBox1.Text = (Math.Log(double.Parse(textBox1.Text))).ToString();
        //    }

        //    private void button22_Click(object sender, EventArgs e)
        //    {
        //        textBox1.Text = (Math.Sqrt(double.Parse(textBox1.Text))).ToString();
        //    }

        //    private void button23_Click(object sender, EventArgs e)
        //    {
        //        num1 = decimal.Parse(textBox1.Text);
        //        operation = "^";
        //        textBox1.Text = "0";
        //    }

        //    private void button18_Click(object sender, EventArgs e)
        //    {
        //        textBox1.Text = (Math.Tan(double.Parse(textBox1.Text))).ToString();
        //    }

        //    private void button21_Click(object sender, EventArgs e)
        //    {
        //        num1 = decimal.Parse(textBox1.Text);
        //        operation = "%";
        //        textBox1.Text = "0";
        //    }
        //}

        //resultValue = Double.Parse(textBox_Result.Text);
        //                labelCurrentOperation.Text = "";
    }
       
}
