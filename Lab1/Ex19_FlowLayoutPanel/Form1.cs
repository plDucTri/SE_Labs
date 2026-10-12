namespace Ex19_FlowLayoutPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button1 = new Button() { Text = "Button 1", AutoSize = true };
            Button button2 = new Button() { Text = "Button 2", AutoSize = true };
            Button button3 = new Button() { Text = "Button 3", AutoSize = true };
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
        }
    }
}
