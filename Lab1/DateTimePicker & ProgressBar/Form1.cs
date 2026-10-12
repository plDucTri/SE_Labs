using Timer = System.Windows.Forms.Timer;

namespace DateTimePicker___ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Timer timer = new Timer();
            timer.Interval = 100; // 100 ms
            timer.Tick += (s, args) =>
            {
                if (progressBar1.Value < 100)
                {
                    progressBar1.Value += 10;
                }
                else
                {
                    timer.Stop();
                    MessageBox.Show("Progress complete!");
                }
            };
            timer.Start();
        }
    }
}
