namespace fukuv0620
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        int answer = random.Next(51);
        int count = 0;
        int bingo;
        int life =5;

        public Form1()
        {
            InitializeComponent();
            textBox2.Text = $"{life}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            MessageBox.Show($"{count}‰ñ–Ú‚Ì’§íA‚ ‚Æ{life}‰ñ");
            int yosou;
            yosou = int.Parse(textBox1.Text);
            if (yosou == answer)
            {
                MessageBox.Show($"Bingo!!");
                count = 0;
                answer = random.Next(51);
                bingo++;
            }
            else if (yosou > answer)
            {
                MessageBox.Show($"ookikatta");
                life--;
                textBox2.Text = $"{life}";
                if (life == 0)
                {
                    MessageBox.Show($"‚ ‚È‚½‚ÍŽ€‚ñ‚¾");
                }
            }
            else if (yosou < answer)
            {
                MessageBox.Show($"chiisakatta");
                life--;
                textBox2.Text = $"{life}";
                if(life == 0)
                {
                    MessageBox.Show($"‚ ‚È‚½‚ÍŽ€‚ñ‚¾");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
