namespace WindowsCalculator
{
    public partial class Form1 : Form
    {
        int firstnum;
        int secondnum;
        string oprand;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            firstnum = Convert.ToInt32(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            secondnum = Convert.ToInt32(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oprand == "+")
            {
                textBox4.Text = Convert.ToString(firstnum + secondnum);
            }
            else if (oprand == "-")
            {
                textBox4.Text = Convert.ToString(firstnum - secondnum);
            }
            else if(oprand == "*")
            {
                textBox4.Text = Convert.ToString(firstnum * secondnum);
            }
            else if(oprand == "/")
            {
                textBox4.Text = Convert.ToString(firstnum / secondnum);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oprand = "+";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oprand = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oprand = "*";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oprand = "/";
        }
    }
}