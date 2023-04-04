using OrderApp;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        OrderService orderService = new OrderService();
        IEnumerable<Order> p;
        Order now;
        List<Order> searchOrders = new List<Order>();
        int row = -1;
        public Form1()
        {
            InitializeComponent();

            //创建orders的成员
            Customer customer1 = new Customer(1, "Peter");
            Customer customer2 = new Customer(2, "Smith");
            Order order1 = new Order(01, customer1, new DateTime(2023, 4, 1));
            Goods milk = new Goods(1, "Milk", 69.9f);
            Goods eggs = new Goods(2, "eggs", 4.99f);
            Goods apple = new Goods(3, "apple", 5.59f);
            order1.AddDetails(new OrderDetail(apple, 8));
            order1.AddDetails(new OrderDetail(eggs, 10));
            orderService.AddOrder(order1);
            Order order2 = new Order(2, customer2, new DateTime(2021, 3, 21));
            order2.AddDetails(new OrderDetail(eggs, 10));
            order2.AddDetails(new OrderDetail(milk, 10));
            orderService.AddOrder(order2);
            OrderSource.DataSource = orderService.QueryAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            if (addForm.GetOrder() != null)
            {
                OrderSource.Add(addForm.GetOrder());
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Object o;
            try
            {
                o = OrderGridView1.Rows[row].DataBoundItem;
                orderService.RemoveOrder(((Order)o).Id);
                SearchMessage.Text = "";
                OrderGridView1.DataSource = orderService.QueryAll();
                OrderDetailGridView2.DataSource = null;
            }
            catch (ArgumentException)
            {
                throw new Exception("没有选择要删除的订单");
            }
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            new Form2(orderService).ShowDialog();
            OrderSource.DataSource = orderService.QueryAll();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string find = SearchMessage.Text;
            string item = SelectProperty.Text;
            switch (item)
            {
                case "id":
                    now = orderService.GetById(Convert.ToInt32(find));
                    break;
                case "Customer":
                    searchOrders = orderService.QueryByCustomerName(find);
                    break;
                case "Goods":
                    searchOrders = orderService.QueryByGoodsName(find);
                    break;
                case "TotalPrice":
                    searchOrders = orderService.QueryByTotalPrice(Convert.ToInt32(find));
                    break;
                default:
                    break;
            }
            if (item == "id") OrderSource.DataSource = now;
            else OrderSource.DataSource = searchOrders;
        }

        private void InputMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            Object o = OrderGridView1.Rows[e.RowIndex].DataBoundItem;
            foreach (object i in orderService.QueryAll())
            {
                if (o == i)
                {
                    Order order = (Order)o;
                    OrderDetailSource.DataSource = order.Details;
                }
            }
        }
    }
}