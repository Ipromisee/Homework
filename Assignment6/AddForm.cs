using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace Assignment6
{
    public partial class AddForm : Form
    {
        int id;
        string Customer;
        int CustomerId;
        Order o;
        public AddForm()
        {
            InitializeComponent();
        }

        public Order GetOrder()
        {
            return o;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            id = Convert.ToInt32(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Customer = Convert.ToString(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CustomerId = Convert.ToInt32(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            o = new Order(id, new Customer(CustomerId, Customer), DateTime.Now);
            Close();
        }
    }
}
