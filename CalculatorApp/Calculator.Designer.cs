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
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.power2 = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.powerXtoY = new System.Windows.Forms.Button();
            this.oneOverX = new System.Windows.Forms.Button();
            this.modulo = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.plusMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(20, 450);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(80, 60);
            this.number1.TabIndex = 1;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(20, 40);
            this.inputBox.Name = "inputBox";
            this.inputBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputBox.Size = new System.Drawing.Size(383, 26);
            this.inputBox.TabIndex = 0;
            this.inputBox.Text = "\r\n";
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(116, 450);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(80, 60);
            this.number2.TabIndex = 6;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(218, 450);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(80, 60);
            this.number3.TabIndex = 7;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(20, 364);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(80, 60);
            this.number4.TabIndex = 8;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(116, 364);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(80, 60);
            this.number5.TabIndex = 9;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(218, 364);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(80, 60);
            this.number6.TabIndex = 10;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(20, 279);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(80, 60);
            this.number7.TabIndex = 11;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(116, 279);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(80, 60);
            this.number8.TabIndex = 12;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(218, 279);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(80, 60);
            this.number9.TabIndex = 13;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(116, 535);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(80, 60);
            this.number0.TabIndex = 14;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(323, 450);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(80, 60);
            this.plus.TabIndex = 15;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(323, 364);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(80, 60);
            this.minus.TabIndex = 16;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(323, 279);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(80, 60);
            this.multiply.TabIndex = 17;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(323, 190);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(80, 60);
            this.divide.TabIndex = 18;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(323, 535);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(80, 60);
            this.equal.TabIndex = 19;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(218, 100);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 60);
            this.clear.TabIndex = 20;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(218, 535);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(80, 60);
            this.dot.TabIndex = 21;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // power2
            // 
            this.power2.Location = new System.Drawing.Point(116, 190);
            this.power2.Name = "power2";
            this.power2.Size = new System.Drawing.Size(80, 60);
            this.power2.TabIndex = 24;
            this.power2.Text = "X^2";
            this.power2.UseVisualStyleBackColor = true;
            this.power2.Click += new System.EventHandler(this.power2_Click);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(218, 190);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(80, 60);
            this.sqrt.TabIndex = 23;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // powerXtoY
            // 
            this.powerXtoY.Location = new System.Drawing.Point(323, 100);
            this.powerXtoY.Name = "powerXtoY";
            this.powerXtoY.Size = new System.Drawing.Size(80, 60);
            this.powerXtoY.TabIndex = 25;
            this.powerXtoY.Text = "X^Y";
            this.powerXtoY.UseVisualStyleBackColor = true;
            this.powerXtoY.Click += new System.EventHandler(this.powerXtoY_Click);
            // 
            // oneOverX
            // 
            this.oneOverX.Location = new System.Drawing.Point(20, 190);
            this.oneOverX.Name = "oneOverX";
            this.oneOverX.Size = new System.Drawing.Size(80, 60);
            this.oneOverX.TabIndex = 26;
            this.oneOverX.Text = "1 / X";
            this.oneOverX.UseVisualStyleBackColor = true;
            this.oneOverX.Click += new System.EventHandler(this.oneOverX_Click);
            // 
            // modulo
            // 
            this.modulo.Location = new System.Drawing.Point(20, 100);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(80, 60);
            this.modulo.TabIndex = 27;
            this.modulo.Text = "mod";
            this.modulo.UseVisualStyleBackColor = true;
            this.modulo.Click += new System.EventHandler(this.remainder_Click);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(116, 100);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(80, 60);
            this.CE.TabIndex = 28;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // plusMinus
            // 
            this.plusMinus.Location = new System.Drawing.Point(20, 535);
            this.plusMinus.Name = "plusMinus";
            this.plusMinus.Size = new System.Drawing.Size(80, 60);
            this.plusMinus.TabIndex = 29;
            this.plusMinus.Text = "+/-";
            this.plusMinus.UseVisualStyleBackColor = true;
            this.plusMinus.Click += new System.EventHandler(this.plusMinus_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 622);
            this.Controls.Add(this.plusMinus);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.oneOverX);
            this.Controls.Add(this.powerXtoY);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.power2);
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

        #endregion
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
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button power2;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button powerXtoY;
        private System.Windows.Forms.Button oneOverX;
        private System.Windows.Forms.Button modulo;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button plusMinus;
    }
}