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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.DarkGreen;
            this.ForeColor = Color.DarkGreen;
            this.Size = new System.Drawing.Size(500, 300);
            this.Text = "Calculator";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            // button apearance
            //this.btnAdd.BackColor = Color.Turquoise;
            //this.btnAdd.Text = "Add";
            //this.btnAdd.Location = new System.Drawing.Point(90, 25);
            //this.btnAdd.Size = new System.Drawing.Size(50, 25);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TextBox mytext = new TextBox();
            //mytext.Location = new Point(25, 25);

            Button myNewButton = new Button()
            {
                Location = new Point(10, 10),
                Size = new Size(120, 25),
                Text = "+"
            };

            myNewButton.Click += MyNewButton_Click;
            this.Controls.Add(myNewButton);

            number1.Click -= button1_Click;
        }

        private void MyNewButton_Click(object sender, EventArgs e)
        {

        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void number1_Click(object sender, KeyPressEventArgs e)
        {
            TextBox mytext = new TextBox();
            mytext.Location = new Point(50, 50);

            if (e.KeyChar == '1')
            {
                inputBox.Text = "1";
                e.Handled = true;
            }
            else
            {
                inputBox.Text = inputBox.Text + "1";
            }
        }

        private void number2_Click(object sender, EventArgs e)
        {
            TextBox mytext = new TextBox();
            mytext.Location = new Point(50, 50);
            
            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "2";
            }
            else
            {
                inputBox.Text = inputBox.Text + "2";
            }
        }

        private void number3_Click(object sender, EventArgs e)
        {
            TextBox mytext = new TextBox();
            mytext.Location = new Point(50, 50);

            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "3";
            }
            else
            {
                inputBox.Text = inputBox.Text + "3";
            }
        }

        private void number4_Click(object sender, EventArgs e)
        {
            TextBox mytext = new TextBox();
            mytext.Location = new Point(50, 50);

            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "4";
            }
            else
            {
                inputBox.Text = inputBox.Text + "4";
            }
        }

        private void number5_Click(object sender, EventArgs e)
        {
            TextBox mytext = new TextBox();
            mytext.Location = new Point(50, 50);

            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "5";
            }
            else
            {
                inputBox.Text = inputBox.Text + "5";
            }
        }

        private void number6_Click(object sender, EventArgs e)
        {
            TextBox mytext = new TextBox();
            mytext.Location = new Point(50, 50);

            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "6";
            }
            else
            {
                inputBox.Text = inputBox.Text + "6";
            }
        }

        private void number7_Click(object sender, EventArgs e)
        {
            TextBox mytext = new TextBox();
            mytext.Location = new Point(50, 50);

            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "7";
            }
            else
            {
                inputBox.Text = inputBox.Text + "7";
            }
        }

        private void number8_Click(object sender, EventArgs e)
        {
            TextBox mytext = new TextBox();
            mytext.Location = new Point(50, 50);

            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "8";
            }
            else
            {
                inputBox.Text = inputBox.Text + "8";
            }
        }

        private void number9_Click(object sender, EventArgs e)
        {
            TextBox mytext = new TextBox();
            mytext.Location = new Point(50, 50);

            if (inputBox.Text == "0" && inputBox.Text != null)
            {
                inputBox.Text = "9";
            }
            else
            {
                inputBox.Text = inputBox.Text + "9";
            }
        }
    }
}
