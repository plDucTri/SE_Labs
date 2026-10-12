using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListBox___ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Item 1");
            listBox1.Items.Add("Item 2");
            comboBox1.Items.Add("Option A");
            comboBox1.Items.Add("Option B");
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();
            string selectedOption = comboBox1.SelectedItem.ToString();
            MessageBox.Show($"ListBox: {selectedItem}, ComboBox: {selectedOption}");
        }
    }

}
