using System;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderservice = new OrderService();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1:add order,2:remove order,3:search order, 4:modify order, 5:quit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        List<OrderDetails> details = new List<OrderDetails>();
                        Console.WriteLine("请输入增加订单的订单号:");
                        string id = Console.ReadLine();
                        Console.WriteLine("请输入增加订单的客户名:");
                        string custom = Console.ReadLine();
                        Console.WriteLine("请输入增加订单的金额:");
                        int money = Convert.ToInt32(Console.ReadLine());
                        while (true)
                        {
                            Console.WriteLine("请输入增加订单的详细信息（如果没了请输入0）:");
                            Console.WriteLine("请输入增加订单的商品名:");
                            string productName=Console.ReadLine();
                            if (productName == "0") break;
                            Console.WriteLine("请输入增加订单的商品数量:");
                            int amount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("请输入增加订单的商品单价:");
                            int unitprice = Convert.ToInt32(Console.ReadLine());
                            OrderDetails od = new OrderDetails(productName, amount, unitprice);
                            details.Add(od);
                        }
                        orderservice.AddOrder(id, custom, money, details);
                        break;
                    case "2":
                        //按生活常识用订单号删除才是唯一合理的方法
                        Console.WriteLine("请输入你所需要删除的订单的信息：");
                        id = Console.ReadLine();
                        IEnumerable<Order> p = orderservice.SearchOrderByID(id);
                        orderservice.RemoveOrder(p);
                        break;
                    case "3":
                        Console.WriteLine("输入1以ID查询，输入2以客户名查询，输入3以金额查询，输入4以商品名查询");
                        string m = Console.ReadLine();
                        switch (m)
                        {
                            case "1":
                                Console.WriteLine("输入订单的id：");
                                id = Console.ReadLine();
                                p = orderservice.SearchOrderByID(id);
                                foreach(Order o in p)
                                {
                                    Console.WriteLine(o);
                                }
                                break;
                            case "2":
                                Console.WriteLine("输入订单的客户名：");
                                string name = Console.ReadLine();
                                p = orderservice.SearchOrderByCustom(name);
                                foreach (Order o in p)
                                {
                                    Console.WriteLine(o);
                                }
                                break;
                            case "3":
                                Console.WriteLine("输入订单的金额：");
                                money = Convert.ToInt32(Console.ReadLine());
                                p = orderservice.SearchOrderByMoney(money);
                                foreach (Order o in p)
                                {
                                    Console.WriteLine(o);
                                }
                                break;
                            case "4":
                                Console.WriteLine("输入订单的商品名称：");
                                name = Console.ReadLine();
                                p = orderservice.SearchOrderByName(name);
                                foreach (Order o in p)
                                {
                                    Console.WriteLine(o);
                                }
                                break;
                            default:
                                Console.WriteLine("输入错误");
                                break;
                        } 
                        break;
                    case "4":
                        //这里只以id进行查找
                        Console.WriteLine("输入所需要修改的order的id：");
                        id = Console.ReadLine();
                        p = orderservice.SearchOrderByID(id);
                        Console.WriteLine("请输入修改后订单的详细信息:");
                        Console.WriteLine("请输入修改后订单的ID:");
                        id = Console.ReadLine();
                        Console.WriteLine("请输入修改后订单的客户名:");
                        custom = Console.ReadLine();
                        Console.WriteLine("请输入修改后订单的金额:");
                        money = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("请输入修改后订单的商品名:");
                        string productName1 = Console.ReadLine();
                        Console.WriteLine("请输入修改后订单的商品数量:");
                        int amount1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("请输入修改后订单的商品单价:");
                        int unitprice1 = Convert.ToInt32(Console.ReadLine());
                        orderservice.ModifyOrder(p,id,custom,money,productName1,amount1,unitprice1);
                        break;
                    case "5":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("输入错误，请重新输入");
                        break;
                }
            }
        }
    }
}