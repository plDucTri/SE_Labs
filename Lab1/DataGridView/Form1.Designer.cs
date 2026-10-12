namespace DataGridView
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            textBoxName = new TextBox();
            addButton = new Button();
            textBoxID = new TextBox();
            textBoxAge = new TextBox();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(126, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(531, 252);
            dataGridView1.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(126, 318);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(228, 27);
            textBoxName.TabIndex = 1;
            textBoxName.Text = "Name";
            // 
            // addButton
            // 
            addButton.Location = new Point(546, 285);
            addButton.Name = "addButton";
            addButton.Size = new Size(111, 34);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(126, 285);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(228, 27);
            textBoxID.TabIndex = 3;
            textBoxID.Text = "ID";
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(126, 351);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(228, 27);
            textBoxAge.TabIndex = 4;
            textBoxAge.Text = "Age";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(546, 342);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(111, 36);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete Row";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxID);
            Controls.Add(addButton);
            Controls.Add(textBoxName);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TextBox textBoxName;
        private Button addButton;
        private TextBox textBoxID;
        private TextBox textBoxAge;
        private Button deleteButton;
    }
}
