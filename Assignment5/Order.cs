using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Order:IComparable
    {
        public string OrderID { get; set; }//订单号
        public string OrderCustom { get; set; }//订单客户
        public int OrderMoney { get; set; }//订单金额
        public List<OrderDetails> Details { get; set; }//订单明细，一个List
        public Order(string orderId,string orderCustom,int orderMoney, List<OrderDetails> details)
        {
            OrderID = orderId;
            OrderCustom = orderCustom;
            OrderMoney = orderMoney;
            Details = details;
        }
        public override string ToString()
        {
            string r = ($"订单号：{OrderID}\n用户名：{OrderCustom}\n总金额：{OrderMoney}\n");
            foreach (OrderDetails od in Details)
            {
                r = r + od.ToString();
            }
            return r;
        }
        public override bool Equals(object? obj)
        {
            Order m = obj as Order;
            return m != null && m.OrderID == this.OrderID ;
        }

        public int CompareTo(object? obj)//缺省使用OrderID进行排序
        {
            if (!(obj is Order))
                throw new System.ArgumentException();
            Order m = obj as Order;
            return OrderID.CompareTo(m.OrderID);
        }
        public bool Contain(string productName)//判断order是否订购了该商品
        {
            foreach(OrderDetails od in Details)
            {
                if (od.ProductName == productName)
                    return true;
            }
            return false;
        }
    }
}
