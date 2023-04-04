using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class AddDetaisForm : Form
    {
        int GoodsId;
        string GoodsName;
        double GoodsSingle;
        int GoodsCount;
        OrderDetail od;
        public AddDetaisForm()
        {
            InitializeComponent();
        }

        public OrderDetail GetOrderDetail()
        {
            return od;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GoodsId = Convert.ToInt32(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            GoodsName = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            GoodsSingle = Convert.ToDouble(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            GoodsCount = Convert.ToInt32(textBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            od = new OrderDetail(new Goods(GoodsId, GoodsName, GoodsSingle), GoodsCount);
            Close();
        }
    }
}
