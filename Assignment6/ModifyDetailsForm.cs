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
    public partial class ModifyDetailsForm : Form
    {
        int GoodsCount;
        double GoodsSingle;
        OrderDetail od = new OrderDetail();
        public ModifyDetailsForm(OrderDetail od)
        {
            InitializeComponent();
            this.od = od;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GoodsCount = Convert.ToInt32(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            GoodsSingle = Convert.ToDouble(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            od.Goods = new Goods(od.Goods.Id, od.Goods.Name, GoodsSingle);
            od.Quantity = GoodsCount;
            Close();
        }
    }
}
