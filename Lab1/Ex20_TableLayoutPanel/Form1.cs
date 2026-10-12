namespace Ex20_TableLayoutPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            // Add controls to the TableLayoutPanel
            Button button1 = new Button() { Text = "Button 1", AutoSize = true};
            Button button2 = new Button() { Text = "Button 2", AutoSize = true};
            Button button3 = new Button() { Text = "Button 3", AutoSize = true};
            Button button4 = new Button() { Text = "Button 4", AutoSize = true};
            Button button5 = new Button() { Text = "Button 5", AutoSize = true};
            Button button6 = new Button() { Text = "Button 6", AutoSize = true};
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Controls.Add(button5, 2, 0);
            tableLayoutPanel1.Controls.Add(button6, 2, 1);
        }
    }
}
