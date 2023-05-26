using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        double FirstNumber;
        string Operation;   
        
        private TextBox txtBox = new TextBox();
        private Button btnAdd = new Button();
        private ListBox lstBox = new ListBox();
        private CheckBox chkBox = new CheckBox();
        private Label lblCount = new Label();

        //public object btnAdd { get; private set; }

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            // appearance
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = Color.DarkGreen;
            ForeColor = Color.DarkGreen;
            Size = new Size(460, 350);
            Text = "Calculator";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;

            // button apearance
            //this.btnAdd.BackColor = Color.Turquoise;
            //this.btnAdd.Text = "Add";
            //this.btnAdd.Location = new System.Drawing.Point(90, 25);
            //this.btnAdd.Size = new System.Drawing.Size(50, 25);
        }

        private void InputBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                if (!string.IsNullOrEmpty(inputBox.Text))
                {
                    if (e.KeyChar == (char)Keys.Add ||
                        e.KeyChar == (char)Keys.Subtract ||
                        e.KeyChar == (char)Keys.Multiply ||
                        e.KeyChar == (char)Keys.Divide)
                    {
                        FirstNumber = Convert.ToDouble(inputBox.Text);
                        inputBox.Text = "0";
                    }
                }
            }
        }

        private void number1_Click(object sender, KeyPressEventArgs e)
        {
            _ = new TextBox { Location = new Point(50, 50) };

            if (e.KeyChar == (char)Keys.D1 && inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "1";
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.D1)
            {
                inputBox.Text += "1";
                e.Handled = true;
            }

            //if (inputBox.Text == "0" && inputBox.Text != null)
            //{
            //    inputBox.Text = "1";
            //}
            //else
            //{
            //    inputBox.Text = inputBox.Text + "1";
            //}
        }

        private void number2_Click(object sender, KeyPressEventArgs e)
        {
            _ = new TextBox { Location = new Point(50, 50) };

            if(e.KeyChar == (char)Keys.D2 && inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "2";
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.D2)
            {
                inputBox.Text += "2";
                e.Handled = true;
            }
        }

        private void number3_Click(object sender, KeyPressEventArgs e)
        {
            _ = new TextBox { Location = new Point(50, 50) };

            if (e.KeyChar == (char)Keys.D3 && inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "3";
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.D3)
            {
                inputBox.Text += "3";
                e.Handled = true;
            }
            //else
            //{
            //    inputBox.Text = inputBox.Text + "3";
            //}
        }

        private void number4_Click(object sender, KeyPressEventArgs e)
        {
            _ = new TextBox { Location = new Point(50, 50) };

            if (e.KeyChar == (char)Keys.D4 && inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "4";
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.D4)
            {
                inputBox.Text += "4";
                e.Handled = true;
            }
        }

        private void number5_Click(object sender, KeyPressEventArgs e)
        {
            _ = new TextBox { Location = new Point(50, 50) };

            if (e.KeyChar == (char)Keys.D5 && inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "5";
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.D5)
            {
                inputBox.Text += "5";
                e.Handled = true;
            }   
        }

        private void number6_Click(object sender, KeyPressEventArgs e)
        {
            _ = new TextBox { Location = new Point(50, 50) };

            if (e.KeyChar == (char)Keys.D6 && inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "6";
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.D6)
            {
                inputBox.Text += "6";
                e.Handled = true;
            }
        }

        private void number7_Click(object sender, KeyPressEventArgs e)
        {
            _ = new TextBox { Location = new Point(50, 50) };

            if (e.KeyChar == (char)Keys.D7 && inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "7";
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.D7)
            {
                inputBox.Text += "7";
                e.Handled = true;
            }
        }

        private void number8_Click(object sender, KeyPressEventArgs e)
        {
            _ = new TextBox { Location = new Point(50, 50) };

            if (e.KeyChar == (char)Keys.D8 && inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "8";
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.D8)
            {
                inputBox.Text += "8";
                e.Handled = true;
            }
        }

        private void number9_Click(object sender, KeyPressEventArgs e)
        {
            _ = new TextBox { Location = new Point(50, 50) };

            if (e.KeyChar == (char)Keys.D9 && inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "9";
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.D9)
            {
                inputBox.Text += "9";
                e.Handled = true;
            }
        }

        private void number0_Click(object sender, KeyPressEventArgs e)
        {
            _ = new TextBox { Location = new Point(50, 50) };

            if (e.KeyChar == (char)Keys.D0 && inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "0";
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.D0)
            {
                inputBox.Text += "0";
                e.Handled = true;
            }
        }

        private void plus_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Add)
            {
                FirstNumber = Convert.ToDouble(inputBox.Text);
                inputBox.Text = "0";
                Operation = "+";
                e.Handled = true;
            }
        }

        private void minus_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Subtract)
            {
                FirstNumber = Convert.ToDouble(inputBox.Text);
                inputBox.Text = "0";
                Operation = "-";
                e.Handled = true;
            }
        }

        private void multiply_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Multiply)
            {
                FirstNumber = Convert.ToDouble(inputBox.Text);
                inputBox.Text = "0";
                Operation = "*";
                e.Handled = true;
            }
        }

        private void divide_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Divide)
            {
                FirstNumber = Convert.ToDouble(inputBox.Text);
                inputBox.Text = "0";
                Operation = "/";
                e.Handled = true;
            }
        }

        private void clear_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.C || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
                inputBox.Text = "0";
                e.Handled = true;
            }
        }

        private void dot_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.OemPeriod)
            {
                inputBox.Text += ".";
                e.Handled = true;
            }
        }

        private void equal_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Oemplus)
            {
                inputBox.Text += "=";
                e.Handled = true;

                double secondNumber;
                double result;

                secondNumber = Convert.ToDouble(inputBox.Text);

                if (Operation == "+")
                {
                    result = FirstNumber + secondNumber;
                    inputBox.Text = Convert.ToString(result);
                    FirstNumber = result;
                }

                if (Operation == "-")
                {
                    result = FirstNumber - secondNumber;
                    inputBox.Text = Convert.ToString(result);
                    FirstNumber = result;
                }

                if (Operation == "*")
                {
                    result = FirstNumber * secondNumber;
                    inputBox.Text = Convert.ToString(result);
                    FirstNumber = result;
                }

                if (Operation == "/")
                {
                    if (secondNumber == 0)
                    {
                        inputBox.Text = "Cannot divide by zero";
                    }
                    else
                    {
                        result = FirstNumber / secondNumber;
                        inputBox.Text = Convert.ToString(result);
                        FirstNumber = result;
                    }
                }

            }
        }
    }
}
