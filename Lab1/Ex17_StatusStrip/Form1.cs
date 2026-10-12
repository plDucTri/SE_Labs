namespace Ex17_StatusStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripStatusLabel statusLabel = new ToolStripStatusLabel("Standing By");
            statusStrip1.Items.Add(statusLabel);
        }
    }
}
