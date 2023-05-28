using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        double FirstNumber;
        string Operation;

        //private TextBox txtBox = new TextBox();
        //private Button btnAdd = new Button();
        //private ListBox lstBox = new ListBox();
        //private CheckBox chkBox = new CheckBox();
        //private Label lblCount = new Label();

        //public object btnAdd { get; private set; }

        public Calculator()
        {
            InitializeComponent();
            //this.KeyPress += new KeyPressEventHandler(Calculator_KeyPress);
        }

        void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                //MessageBox.Show($"The Key {e.KeyChar} was pressed.");

                //switch ((int)e.KeyChar)
                //{
                //    case 35:
                //        multiply_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    case 43:
                //        plus_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    case 45:
                //        minus_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    case 46:
                //        dot_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    case 47:
                //        divide_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    case 61:
                //        equal_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    case 48:
                //        number0_Click(number0, e);
                //        e.Handled = true;
                //        break;
                //    case 49:
                //        number1_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    case 50:
                //        number2_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    case 51:
                //        number3_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    case 52:
                //        number4_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    case 53:
                //        number5_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    case 54:
                //        number6_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    case 55:
                //        number7_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    case 56:
                //        number8_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    case 57:
                //        number9_Click(sender, e);
                //        e.Handled = true;
                //        break;
                //    default:
                //        MessageBox.Show("Form.KeyPress: '" +
                //                        e.KeyChar.ToString() + "' consumed.");
                //        e.Handled = true;
                //        break;
                //}
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            // appearance
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = Color.Black;
            ForeColor = Color.Black;
            Size = new Size(460, 350);
            Text = "Calculator";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;

            KeyPreview = true;
            //KeyPress += Calculator_KeyPress;

            // button apearance
            //this.btnAdd.BackColor = Color.Turquoise;
            //this.btnAdd.Text = "Add";
            //this.btnAdd.Location = new System.Drawing.Point(90, 25);
            //this.btnAdd.Size = new System.Drawing.Size(50, 25);
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(inputBox.Text, "/^\\d*\\.?\\d*$/"))
            {
                //MessageBox.Show("Please enter only numbers.");
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
            }
        }

        private void number1_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "1";
            }
            else
            {
                inputBox.Text += "1";
            }
        }

        private void number2_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "2";
            }
            else
            {
                inputBox.Text += "2";
            }
        }

        private void number3_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "3";
            }
            else
            {
                inputBox.Text += "3";
            }
        }

        private void number4_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "4";
            }
            else
            {
                inputBox.Text += "4";
            }
        }

        private void number5_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "5";
            }
            else
            {
                inputBox.Text += "5";
            }
        }

        private void number6_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "6";
            }
            else
            {
                inputBox.Text += "6";
            }
        }

        private void number7_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "7";
            }
            else
            {
                inputBox.Text += "7";
            }
        }

        private void number8_Click(object sender,  EventArgs e)
        {
            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "8";
            }
            else
            {
                inputBox.Text += "8";
            }
        }

        private void number9_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "9";
            }
            else
            {
                inputBox.Text += "9";
            }
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "0";
            }
            else
            {
                inputBox.Text += "0";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputBox.Text);
            inputBox.Text = "";
            Operation = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputBox.Text);
            inputBox.Text = "";
            Operation = "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputBox.Text);
            inputBox.Text = "";
            Operation = "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputBox.Text);
            inputBox.Text = "";
            Operation = "/";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "";
            }
            else
            {
                inputBox.Text += "";
            }
        }

        private void power2_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputBox.Text);
            double result = Math.Pow(FirstNumber, 2);
            inputBox.Text = result.ToString();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputBox.Text);
            double result = Math.Sqrt(FirstNumber);
            inputBox.Text = result.ToString();
        }

        private void equal_Click(object sender, EventArgs e)
        { 

            double result;
            double SecondNumber;

            SecondNumber = Convert.ToDouble(inputBox.Text);

            if (Operation == "+")
                {
                    result = FirstNumber + SecondNumber;
                    inputBox.Text = Convert.ToString(result);
                    FirstNumber = result;
                }

            if (Operation == "-")
            {
                result = FirstNumber - SecondNumber;
                inputBox.Text = Convert.ToString(result);
                FirstNumber = result;
            }

            if (Operation == "*")
            {
                result = FirstNumber * SecondNumber;
                inputBox.Text = Convert.ToString(result);
                FirstNumber = result;
            }

            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    inputBox.Text = "Cannot divide by zero";
                }
                else
                {
                    result = FirstNumber / SecondNumber;
                    inputBox.Text = Convert.ToString(result);
                    FirstNumber = result;
                }
            }
        }
    }
}