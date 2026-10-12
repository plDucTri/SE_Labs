namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 + num2;
            resultLabel.Text = result.ToString();
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 - num2;
            resultLabel.Text = result.ToString();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 * num2;
            resultLabel.Text = result.ToString();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            if(num2 == 0)
            {
                resultLabel.Text = "Division by 0";
            }
            else
            {
                double result = num1 / num2;
                resultLabel.Text = result.ToString();
            }
        }
    }
}
