﻿namespace CalculatorApp
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
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
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
            this.inputBox.Size = new System.Drawing.Size(620, 26);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            System.Windows.Forms.KeyPressEventHandler keyPressEventHandler = new System.Windows.Forms.KeyPressEventHandler(this.InputBox_TextChanged);
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
            // plusButton
            // 
            this.plus.Location = new System.Drawing.Point(260, 100);
            this.plus.Name = "button1";
            this.plus.Size = new System.Drawing.Size(80, 60);
            this.plus.TabIndex = 15;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.plus_Click);
            // 
            // minusButton
            // 
            this.minus.Location = new System.Drawing.Point(360, 100);
            this.minus.Name = "button2";
            this.minus.Size = new System.Drawing.Size(80, 60);
            this.minus.TabIndex = 16;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minus_Click);
            // 
            // multiplyButton
            // 
            this.multiply.Location = new System.Drawing.Point(460, 100);
            this.multiply.Name = "button3";
            this.multiply.Size = new System.Drawing.Size(80, 60);
            this.multiply.TabIndex = 17;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.multiply_Click);
            // 
            // divideButton
            // 
            this.divide.Location = new System.Drawing.Point(560, 100);
            this.divide.Name = "button4";
            this.divide.Size = new System.Drawing.Size(80, 60);
            this.divide.TabIndex = 18;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.divide_Click);
            // 
            // equalButton
            // 
            this.equal.Location = new System.Drawing.Point(460, 200);
            this.equal.Name = "button5";
            this.equal.Size = new System.Drawing.Size(180, 60);
            this.equal.TabIndex = 19;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.equal_Click);
            // 
            // clearButton
            // 
            this.clear.Location = new System.Drawing.Point(260, 200);
            this.clear.Name = "C";
            this.clear.Size = new System.Drawing.Size(80, 60);
            this.clear.TabIndex = 20;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clear_Click);
            // 
            // dotButton
            // 
            this.dot.Location = new System.Drawing.Point(360, 200);
            this.dot.Name = ".";
            this.dot.Size = new System.Drawing.Size(80, 60);
            this.dot.TabIndex = 21;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dot_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
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

        private void InputBox_TextChanged1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
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
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button dot;
    }
}

