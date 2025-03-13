using System.DirectoryServices;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private double CalculateExpression(string expression)
        {
            var table = new System.Data.DataTable();
            expression = expression.Replace('×', '*');
            expression = expression.Replace('÷', '/');
            return Convert.ToDouble(table.Compute(expression, string.Empty));
        }
        private void Equal_Button(object sender, EventArgs e)
        {
            string expression = Display.Text;
            try
            {
                double result = CalculateExpression(expression);
                Display.Text = result.ToString();

            } catch (Exception)
            {
                Display.Text = "Error";
            }
        }
        private void AddMultiply(object sender, EventArgs e)
        {
            AddOperator(sender, e, '×');
        }
        private void AddDivision(object sender, EventArgs e)
        {
            AddOperator(sender, e, '÷');
        }
        private void AddAddition(object sender, EventArgs e)
        {
            AddOperator(sender, e, '+');
        }
        void AddSubtraction(object sender, EventArgs e)
        {
            AddOperator(sender, e, '-');
        }

        private void AddOperator(object sender, EventArgs e, char operators)
        {
            Display.Text += operators;
        }
        private void NumberButton_Click (object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            if (clickedbutton != null )
            {
                if (Display.Text == "0")
                {
                    Display.Text = clickedbutton.Text;
                    return;
                }
                Display.Text += clickedbutton.Text;
            }
        }
        private void DeleteDigit(object sender, EventArgs e)
        {
            if (Display.Text.Length > 1)
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
            } else
            {
                Display.Text = "0";
            }
        }
        private void Clear_Digits(object sender, EventArgs e)
        {
            Display.Text = "0";
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Num1 = new Button();
            Display = new Label();
            Num2 = new Button();
            Num3 = new Button();
            MultiplySymbol = new Button();
            DivisionSymbol = new Button();
            AddSymbol = new Button();
            SubtractSymbol = new Button();
            Num4 = new Button();
            Num5 = new Button();
            Num6 = new Button();
            Num7 = new Button();
            Num8 = new Button();
            Num9 = new Button();
            Num0 = new Button();
            ClearButton = new Button();
            DeleteButton = new Button();
            Credits = new Label();
            EqualButton = new Button();
            SuspendLayout();
            // 
            // Num1
            // 
            Num1.Location = new Point(10, 86);
            Num1.Name = "Num1";
            Num1.Size = new Size(96, 29);
            Num1.TabIndex = 1;
            Num1.Text = "1";
            Num1.UseVisualStyleBackColor = true;
            Num1.Click += NumberButton_Click;
            // 
            // Display
            // 
            Display.BackColor = Color.White;
            Display.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Display.Location = new Point(10, 22);
            Display.Margin = new Padding(8, 0, 3, 0);
            Display.Name = "Display";
            Display.Padding = new Padding(8, 0, 0, 0);
            Display.Size = new Size(336, 51);
            Display.TabIndex = 2;
            Display.Text = "0";
            Display.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Num2
            // 
            Num2.Location = new Point(112, 86);
            Num2.Name = "Num2";
            Num2.Size = new Size(94, 29);
            Num2.TabIndex = 3;
            Num2.Text = "2";
            Num2.UseVisualStyleBackColor = true;
            Num2.Click += NumberButton_Click;
            // 
            // Num3
            // 
            Num3.Location = new Point(212, 86);
            Num3.Name = "Num3";
            Num3.Size = new Size(94, 29);
            Num3.TabIndex = 4;
            Num3.Text = "3";
            Num3.UseVisualStyleBackColor = true;
            Num3.Click += NumberButton_Click;
            // 
            // MultiplySymbol
            // 
            MultiplySymbol.Location = new Point(312, 191);
            MultiplySymbol.Name = "MultiplySymbol";
            MultiplySymbol.Size = new Size(38, 29);
            MultiplySymbol.TabIndex = 5;
            MultiplySymbol.Text = "×";
            MultiplySymbol.UseVisualStyleBackColor = true;
            MultiplySymbol.Click += AddMultiply;
            // 
            // DivisionSymbol
            // 
            DivisionSymbol.Location = new Point(312, 255);
            DivisionSymbol.Name = "DivisionSymbol";
            DivisionSymbol.Size = new Size(38, 29);
            DivisionSymbol.TabIndex = 6;
            DivisionSymbol.Text = "÷";
            DivisionSymbol.UseVisualStyleBackColor = true;
            DivisionSymbol.Click += AddDivision;
            // 
            // AddSymbol
            // 
            AddSymbol.Location = new Point(312, 86);
            AddSymbol.Name = "AddSymbol";
            AddSymbol.Size = new Size(38, 29);
            AddSymbol.TabIndex = 7;
            AddSymbol.Text = "+";
            AddSymbol.UseVisualStyleBackColor = true;
            AddSymbol.Click += AddAddition;
            // 
            // SubtractSymbol
            // 
            SubtractSymbol.Location = new Point(312, 134);
            SubtractSymbol.Name = "SubtractSymbol";
            SubtractSymbol.Size = new Size(38, 29);
            SubtractSymbol.TabIndex = 8;
            SubtractSymbol.Text = "-";
            SubtractSymbol.UseVisualStyleBackColor = true;
            SubtractSymbol.Click += AddSubtraction;
            // 
            // Num4
            // 
            Num4.Location = new Point(10, 134);
            Num4.Name = "Num4";
            Num4.Size = new Size(94, 29);
            Num4.TabIndex = 9;
            Num4.Text = "4";
            Num4.UseVisualStyleBackColor = true;
            Num4.Click += NumberButton_Click;
            // 
            // Num5
            // 
            Num5.Location = new Point(112, 134);
            Num5.Name = "Num5";
            Num5.Size = new Size(94, 29);
            Num5.TabIndex = 10;
            Num5.Text = "5";
            Num5.UseVisualStyleBackColor = true;
            Num5.Click += NumberButton_Click;
            // 
            // Num6
            // 
            Num6.Location = new Point(212, 134);
            Num6.Name = "Num6";
            Num6.Size = new Size(94, 29);
            Num6.TabIndex = 11;
            Num6.Text = "6";
            Num6.UseVisualStyleBackColor = true;
            Num6.Click += NumberButton_Click;
            // 
            // Num7
            // 
            Num7.Location = new Point(10, 191);
            Num7.Name = "Num7";
            Num7.Size = new Size(94, 29);
            Num7.TabIndex = 12;
            Num7.Text = "7";
            Num7.UseVisualStyleBackColor = true;
            Num7.Click += NumberButton_Click;
            // 
            // Num8
            // 
            Num8.Location = new Point(112, 191);
            Num8.Name = "Num8";
            Num8.Size = new Size(94, 29);
            Num8.TabIndex = 13;
            Num8.Text = "8";
            Num8.UseVisualStyleBackColor = true;
            Num8.Click += NumberButton_Click;
            // 
            // Num9
            // 
            Num9.Location = new Point(212, 191);
            Num9.Name = "Num9";
            Num9.Size = new Size(94, 29);
            Num9.TabIndex = 14;
            Num9.Text = "9";
            Num9.UseVisualStyleBackColor = true;
            Num9.Click += NumberButton_Click;
            // 
            // Num0
            // 
            Num0.Location = new Point(112, 255);
            Num0.Name = "Num0";
            Num0.Size = new Size(94, 29);
            Num0.TabIndex = 15;
            Num0.Text = "0";
            Num0.UseVisualStyleBackColor = true;
            Num0.Click += NumberButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(10, 255);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 16;
            ClearButton.Text = "C";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += Clear_Digits;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(212, 255);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 17;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteDigit;
            // 
            // Credits
            // 
            Credits.AutoSize = true;
            Credits.BackColor = Color.LightCoral;
            Credits.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Credits.Location = new Point(10, 421);
            Credits.Name = "Credits";
            Credits.Size = new Size(235, 20);
            Credits.TabIndex = 18;
            Credits.Text = "Made with 💖 by superhenryman";
            // 
            // EqualButton
            // 
            EqualButton.Location = new Point(112, 340);
            EqualButton.Name = "EqualButton";
            EqualButton.Size = new Size(115, 29);
            EqualButton.TabIndex = 19;
            EqualButton.Text = "=";
            EqualButton.UseVisualStyleBackColor = true;
            EqualButton.Click += Equal_Button;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(362, 450);
            Controls.Add(EqualButton);
            Controls.Add(Credits);
            Controls.Add(DeleteButton);
            Controls.Add(ClearButton);
            Controls.Add(Num0);
            Controls.Add(Num9);
            Controls.Add(Num8);
            Controls.Add(Num7);
            Controls.Add(Num6);
            Controls.Add(Num5);
            Controls.Add(Num4);
            Controls.Add(SubtractSymbol);
            Controls.Add(AddSymbol);
            Controls.Add(DivisionSymbol);
            Controls.Add(MultiplySymbol);
            Controls.Add(Num3);
            Controls.Add(Num2);
            Controls.Add(Display);
            Controls.Add(Num1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button Num1;
        private Label Display;
        private Button Num2;
        private Button Num3;
        private Button MultiplySymbol;
        private Button DivisionSymbol;
        private Button AddSymbol;
        private Button SubtractSymbol;
        private Button Num4;
        private Button Num5;
        private Button Num6;
        private Button Num7;
        private Button Num8;
        private Button Num9;
        private Button Num0;
        private Button ClearButton;
        private Button DeleteButton;
        private Label Credits;
        private Button EqualButton;
    }
}
