using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderService
    {
        public List<Order> orders = new List<Order>();//一个订单list
        //查找订单,通过订单号查找
        public IEnumerable<Order> SearchOrderByID(string find)
        {
            var q = orders.Where(s => s.OrderID == find).OrderBy(s => s.OrderMoney);
            return q;
        }
        //通过订单客户查找
        public IEnumerable<Order> SearchOrderByCustom(string find)
        {
            var q = orders.Where(s => s.OrderCustom == find).OrderBy(s => s.OrderMoney);
            return q;
        }
        //通过订单金额进行查询
        public IEnumerable<Order> SearchOrderByMoney(int find)
        {
            var q = orders.Where(s => s.OrderMoney == find);
            return q;
        }
        //通过商品名称进行查询，只要有订这个商品就取出
        public IEnumerable<Order> SearchOrderByName(string find)
        {
            var q = orders.Where(s => s.Contain(find)).OrderBy(s => s.OrderMoney);
            return q;
        }
        //增加订单
        public void AddOrder(string id, string customer, int money, List<OrderDetails> list)
        {
            Order o = new Order(id, customer, money, list);
            foreach (Order a in orders)
            {
                if (o.Equals(a))
                {
                    throw new Exception("添加错误，已有该订单");
                }
            }
            orders.Add(o);
        }
        //删除订单
        public void RemoveOrder(IEnumerable<Order> p)
        {
            if (p.Count() != 0)
            {
                foreach (Order o in p)
                {
                    orders.Remove(o);
                }
            }
            else
            {
                Exception ex = new Exception("没有该订单");
                throw ex;
            }
        }
        //修改订单，修改的订单一定只能是一个
        public void ModifyOrder(IEnumerable<Order> p, string id, string custom, int money, string productName, int amount, int unitprice)
        {
            if (p.Count() != 0)
            {
                if(p.Count()==1)//如果只有一个则删除
                {
                    foreach (Order o in p)
                    {
                        o.OrderID = id;
                        o.OrderCustom = custom;
                        o.OrderMoney = money;
                        foreach(OrderDetails a in o.Details)
                        {
                            if(a.ProductName == productName)
                            {
                                a.Amount = amount;
                                a.UnitPrice = unitprice;
                            }
                        }
                    }
                }
                else
                {
                    Exception ex = new Exception("请详细查询，避免删除其他订单");
                    throw ex;
                }
            }
            else
            {
                Exception ex = new Exception("没有该订单");
                throw ex;
            }
        }
    }
}
