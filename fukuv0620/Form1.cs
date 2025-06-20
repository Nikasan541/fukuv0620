namespace fukuv0620
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        int answer = random.Next(51);
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            MessageBox.Show($"{count}‰ñ–Ú‚Ì’§í");
            int yosou;
            yosou = int.Parse(textBox1.Text);
            if (yosou == answer)
            {
                MessageBox.Show($"Bingo!!");
                count = 0;
                answer = random.Next(51);
            }
            else if (yosou > answer)
            {
                MessageBox.Show($"ookikatta");
            }
            else if (yosou < answer)
            {
                MessageBox.Show($"chiisakatta");
            }
        }
    }
}
