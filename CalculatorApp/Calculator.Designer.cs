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
            this.SuspendLayout();
           
            this.inputBox.Location = new System.Drawing.Point(20, 40);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(680, 100);
            this.inputBox.TabIndex = ;
            this.inputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            
            this.number1.Location = new System.Drawing.Point(20, 100);
            this.number1.Name = "1";
            this.number1.Size = new System.Drawing.Size(60, 60);
            this.number1.TabIndex = 0;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number1_Click);
           
            this.number2.Location = new System.Drawing.Point(100, 100);
            this.number2.Name = "2";
            this.number2.Size = new System.Drawing.Size(60, 60);
            this.number2.TabIndex = 6;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            
            this.number3.Location = new System.Drawing.Point(180, 100);
            this.number3.Name = "3";
            this.number3.Size = new System.Drawing.Size(60, 60);
            this.number3.TabIndex = 7;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
             
            this.number4.Location = new System.Drawing.Point(20, 200);
            this.number4.Name = "4";
            this.number4.Size = new System.Drawing.Size(60, 60);
            this.number4.TabIndex = 8;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            
            this.number5.Location = new System.Drawing.Point(100, 200);
            this.number5.Name = "5";
            this.number5.Size = new System.Drawing.Size(60, 60);
            this.number5.TabIndex = 9;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            
            this.number6.Location = new System.Drawing.Point(180, 200);
            this.number6.Name = "6";
            this.number6.Size = new System.Drawing.Size(60, 60);
            this.number6.TabIndex = 10;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            
            this.number7.Location = new System.Drawing.Point(20, 300);
            this.number7.Name = "7";
            this.number7.Size = new System.Drawing.Size(60, 60);
            this.number7.TabIndex = 11;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            
            this.number8.Location = new System.Drawing.Point(100, 300);
            this.number8.Name = "8";
            this.number8.Size = new System.Drawing.Size(60, 60);
            this.number8.TabIndex = 12;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            
            this.number9.Location = new System.Drawing.Point(180, 300);
            this.number9.Name = "9";
            this.number9.Size = new System.Drawing.Size(60, 60);
            this.number9.TabIndex = 13;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

