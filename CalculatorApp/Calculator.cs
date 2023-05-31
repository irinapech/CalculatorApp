﻿using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        string Operation;
        double FirstNumber;

        public Calculator()
        {
            InitializeComponent();
        }

        void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            // appearance
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = Color.Black;
            ForeColor = Color.Black;
            Size = new Size(300, 450);
            Text = "Calculator";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;

            KeyPreview = true;
            KeyPress += Calculator_KeyPress;
        }

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            HideCaret(inputBox.Handle);
            if (System.Text.RegularExpressions.Regex.IsMatch(inputBox.Text, "/^\\d*\\.?\\d*$/"))
            {
                MessageBox.Show("Please enter only numbers.");
                if (!string.IsNullOrWhiteSpace(inputBox.Text))
                {
                    inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
                }
            }
        }

        private void Number_Click(string digit)
        {
            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = digit;
            }
            else
            {
                inputBox.Text += digit;
            }
        }
        private void number1_Click(object sender, EventArgs e)
        {
            Number_Click("1");
        }

        private void number2_Click(object sender, EventArgs e)
        {
            Number_Click("2");
        }

        private void number3_Click(object sender, EventArgs e)
        {
            Number_Click("3");
        }

        private void number4_Click(object sender, EventArgs e)
        {
            Number_Click("4");
        }

        private void number5_Click(object sender, EventArgs e)
        {
            Number_Click("5");
        }

        private void number6_Click(object sender, EventArgs e)
        {
            Number_Click("6");
        }

        private void number7_Click(object sender, EventArgs e)
        {
            Number_Click("7");
        }

        private void number8_Click(object sender, EventArgs e)
        {
            Number_Click("8");
        }

        private void number9_Click(object sender, EventArgs e)
        {
            Number_Click("9");
        }

        private void number0_Click(object sender, EventArgs e)
        {
            Number_Click("0");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(inputBox.Text.Last()) && inputBox.Text.Last() != '.')
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
            }
            inputBox.Text += "+";
            Operation = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(inputBox.Text.Last()) && inputBox.Text.Last() != '.')
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
            }
            inputBox.Text += "-";
            Operation = "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(inputBox.Text.Last()) && inputBox.Text.Last() != '.')
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
            }
            inputBox.Text += "*";
            Operation = "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(inputBox.Text.Last()) && inputBox.Text.Last() != '.')
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
            }
            inputBox.Text += "/";
            Operation = "/";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputBox.Text = "0";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputBox.Text))
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
                if (string.IsNullOrWhiteSpace(inputBox.Text))
                {
                    inputBox.Text = "0";
                }
            }
            else
            {
                inputBox.Text = "0";
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!inputBox.Text.Contains("."))
            {
                if (inputBox.Text == null)
                {
                    inputBox.Text = "0.";
                }
                else
                {
                    inputBox.Text += ".";
                }
            }
        }

        private void power2_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(inputBox.Text.Last()) && inputBox.Text.Last() != '.')
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
            }

            double FirstNumber = Convert.ToDouble(inputBox.Text);
            double result = Math.Pow(FirstNumber, 2);
            if (Math.Abs(result - (int)result) > 0)
            {
                inputBox.Text = result.ToString("0.00");
            }
            else
            {
                inputBox.Text = result.ToString();
            }
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(inputBox.Text.Last()) && inputBox.Text.Last() != '.')
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
            }

            double FirstNumber = Convert.ToDouble(inputBox.Text);
            if (FirstNumber < 0)
            {
                inputBox.Text = "Invalid Input";
            }
            else
            {
                double result = Math.Sqrt(FirstNumber);
                if (Math.Abs(result - (int)result) > 0)
                {
                    inputBox.Text = result.ToString("0.00");
                }
                else
                {
                    inputBox.Text = result.ToString();
                }
            }
        }

        private void powerXtoY_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(inputBox.Text.Last()) && inputBox.Text.Last() != '.')
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
            }
            inputBox.Text += "^";
            Operation = "^";
        }

        private void oneOverX_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(inputBox.Text.Last()) && inputBox.Text.Last() != '.')
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
            }

            double FirstNumber = Convert.ToDouble(inputBox.Text);
            double result = 1 / FirstNumber;
            if (Math.Abs(result - (int)result) > 0)
            {
                inputBox.Text = result.ToString("0.00");
            }
            else
            {
                inputBox.Text = result.ToString();
            }
        }

        private void remainder_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(inputBox.Text.Last()) && inputBox.Text.Last() != '.')
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
            }

            double FirstNumber = Convert.ToDouble(inputBox.Text);
            inputBox.Text += "%";
            Operation = "%";
        }

        private void plusMinus_Click(object sender, EventArgs e)
        {
            char tempOperation;
            double FirstNumber, result;
            if (!Char.IsDigit(inputBox.Text.Last()) && inputBox.Text.Last() != '.')
            {
                tempOperation = inputBox.Text.Last();
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
                FirstNumber = Convert.ToDouble(inputBox.Text);
                result = (FirstNumber) * (-1);
                if (Math.Abs(result - (int)result) > 0)
                {
                    inputBox.Text = result.ToString("0.00") + tempOperation;
                }
                else
                {
                    inputBox.Text = result.ToString() + tempOperation;
                }
            }
            else
            {
                FirstNumber = Convert.ToDouble(inputBox.Text);
                result = FirstNumber * (-1);
                if (Math.Abs(result - (int)result) > 0)
                {
                    inputBox.Text = result.ToString("0.00");
                }
                else
                {
                    inputBox.Text = result.ToString();
                }
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {

            double result;
            double SecondNumber;

            if (inputBox.Text.Length > 0)
            {

                try
                {
                    FirstNumber = Convert.ToDouble(inputBox.Text.Remove(inputBox.Text.IndexOf(Operation)));
                }
                catch
                {
                    FirstNumber = 0;
                }

                try
                {
                    SecondNumber = Convert.ToDouble(inputBox.Text.Substring(inputBox.Text.IndexOf(Operation) + 1));

                }
                catch
                {
                    SecondNumber = 0;
                }
                if (Operation == "+")
                {
                    result = FirstNumber + SecondNumber;
                    if (Math.Abs(result - (int)result) > 0)
                    {
                        inputBox.Text = result.ToString("0.00");
                    }
                    else
                    {
                        inputBox.Text = result.ToString();
                    }

                    FirstNumber = result;
                }

                if (Operation == "-")
                {
                    result = FirstNumber - SecondNumber;
                    if (Math.Abs(result - (int)result) > 0)
                    {
                        inputBox.Text = result.ToString("0.00");
                    }
                    else
                    {
                        inputBox.Text = result.ToString();
                    }
                    FirstNumber = result;
                }

                if (Operation == "*")
                {
                    result = FirstNumber * SecondNumber;
                    if (Math.Abs(result - (int)result) > 0)
                    {
                        inputBox.Text = result.ToString("0.00");
                    }
                    else
                    {
                        inputBox.Text = result.ToString();
                    }
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
                        if (Math.Abs(result - (int)result) > 0)
                        {
                            inputBox.Text = result.ToString("0.00");
                        }
                        else
                        {
                            inputBox.Text = result.ToString();
                        }
                        FirstNumber = result;
                    }
                }

                if (Operation == "^")
                {
                    result = Math.Pow(FirstNumber, SecondNumber);
                    if (Math.Abs(result - (int)result) > 0)
                    {
                        inputBox.Text = result.ToString("0.00");
                    }
                    else
                    {
                        inputBox.Text = result.ToString();
                    }
                    FirstNumber = result;
                }

                if (Operation == "%")
                {
                    if (SecondNumber == 0)
                    {
                        inputBox.Text = "Cannot divide by zero";
                    }
                    else
                    {
                        result = FirstNumber % SecondNumber;
                        if (Math.Abs(result - (int)result) > 0)
                        {
                            inputBox.Text = result.ToString("0.00");
                        }
                        else
                        {
                            inputBox.Text = result.ToString();
                        }
                        FirstNumber = result;
                    }
                }
            }
        }
    }
}