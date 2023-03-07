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
            string str;
            str = textBox1.Text;
            if (str == null || str.Length == 0)
            {
                firstnum = 0;
            }
            else
            {
                firstnum = Convert.ToInt32(str);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string str;
            str = textBox2.Text;
            if (str == null || str.Length == 0)
            {
                secondnum = 0;
            }
            else
            {
                secondnum = Convert.ToInt32(str);
            }
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
                if (secondnum == 0)
                {
                    textBox4.Text = "除数不能为0！！！";
                }
                else
                {
                    textBox4.Text = Convert.ToString(firstnum / secondnum);
                }
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