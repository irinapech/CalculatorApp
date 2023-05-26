namespace CalculatorApp
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.number1 = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(20, 100);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(60, 60);
            this.number1.TabIndex = 1;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number1_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(20, 40);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(680, 26);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(100, 100);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(60, 60);
            this.number2.TabIndex = 6;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number2_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(180, 100);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(60, 60);
            this.number3.TabIndex = 7;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number3_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(20, 200);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(60, 60);
            this.number4.TabIndex = 8;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number4_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(100, 200);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(60, 60);
            this.number5.TabIndex = 9;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number5_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(180, 200);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(60, 60);
            this.number6.TabIndex = 10;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number6_Click);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(20, 300);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(60, 60);
            this.number7.TabIndex = 11;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number7_Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(100, 300);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(60, 60);
            this.number8.TabIndex = 12;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number8_Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(180, 300);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(60, 60);
            this.number9.TabIndex = 13;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number9_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(100, 400);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(60, 60);
            this.number0.TabIndex = 14;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number0_Click);
            // 
            // add
            // 
            this.button1.Location = new System.Drawing.Point(287, 100);
            this.button1.Name = "+";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 15;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // subtract
            // 
            this.button2.Location = new System.Drawing.Point(388, 100);
            this.button2.Name = "-";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 16;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.button3.Location = new System.Drawing.Point(487, 100);
            this.button3.Name = "*";
            this.button3.Size = new System.Drawing.Size(75, 60);
            this.button3.TabIndex = 17;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.button4.Location = new System.Drawing.Point(585, 100);
            this.button4.Name = "/";
            this.button4.Size = new System.Drawing.Size(75, 60);
            this.button4.TabIndex = 18;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // equal
            // 
            this.button5.Location = new System.Drawing.Point(687, 100);
            this.button5.Name = "=";
            this.button5.Size = new System.Drawing.Size(75, 60);
            this.button5.TabIndex = 19;
            this.button5.Text = "=";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

