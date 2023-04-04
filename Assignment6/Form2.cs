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
    public partial class Form2 : Form
    {
        Order now;
        object o;
        int row = -1;
        OrderService orderService = new OrderService();
        public Form2(OrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            if (id != "") now = orderService.GetById(Convert.ToInt32(id));
            if (now != null)
            {
                Customer.Text = now.Customer.ToString();
                Customer.Text = now.Customer.ToString();
                CreatTime.Text = now.CreateTime.ToString();
                DetailSource.DataSource = now.Details;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Object o = DetailGridView.Rows[row].DataBoundItem;
            int idx = now.Details.FindIndex(d => d == (OrderDetail)o);
            now.RemoveDetails(idx);
            DetailGridView.DataSource = now.Details;
        }

        private void DetailGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            o = DetailGridView.Rows[e.RowIndex].DataBoundItem;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddDetaisForm addDetaisForm = new AddDetaisForm();
            addDetaisForm.ShowDialog();
            if (addDetaisForm.GetOrderDetail() != null)
            {
                DetailSource.Add(addDetaisForm.GetOrderDetail());
            }
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            Object od = DetailGridView.Rows[row].DataBoundItem;
            DetailSource.Remove(od);
            ModifyDetailsForm modifyDetailsForm = new ModifyDetailsForm((OrderDetail)od);
            modifyDetailsForm.ShowDialog();
            DetailSource.Add(od);
        }
    }
}
