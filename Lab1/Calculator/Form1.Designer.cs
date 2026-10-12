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
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Add = new Button();
            Substract = new Button();
            Multiply = new Button();
            Divide = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(315, 238);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(315, 293);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // Add
            // 
            Add.Location = new Point(621, 236);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 2;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Substract
            // 
            Substract.Location = new Point(736, 236);
            Substract.Name = "Substract";
            Substract.Size = new Size(94, 29);
            Substract.TabIndex = 3;
            Substract.Text = "Substract";
            Substract.UseVisualStyleBackColor = true;
            Substract.Click += Substract_Click;
            // 
            // Multiply
            // 
            Multiply.Location = new Point(621, 293);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(94, 29);
            Multiply.TabIndex = 4;
            Multiply.Text = "Multiply";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += Multiply_Click;
            // 
            // Divide
            // 
            Divide.Location = new Point(736, 293);
            Divide.Name = "Divide";
            Divide.Size = new Size(94, 29);
            Divide.TabIndex = 5;
            Divide.Text = "Divide";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Divide_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(510, 146);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(49, 20);
            resultLabel.TabIndex = 6;
            resultLabel.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 516);
            Controls.Add(resultLabel);
            Controls.Add(Divide);
            Controls.Add(Multiply);
            Controls.Add(Substract);
            Controls.Add(Add);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button Add;
        private Button Substract;
        private Button Multiply;
        private Button Divide;
        private Label resultLabel;
    }
}
