using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderDetails
    {
        public string ProductName { get; set; }//订单商品名称
        public int Amount { get; set; }//订单商品数量
        public int UnitPrice { get; set; }//订单商品单价
        public OrderDetails(string productName ,int amount,int unitprice)
        {
            ProductName = productName;
            Amount = amount;
            UnitPrice = unitprice;
        }
        public int getAllPrice()
        {
            return Amount * UnitPrice;
        }
        public override string ToString()
        {
            return "商品名称： " + ProductName + "\n商品数量： " 
                + Amount + "\n商品单价： " + UnitPrice;
        }
        public override bool Equals(object? obj)
        {
            OrderDetails m = obj as OrderDetails;
            return m != null && m.ProductName == this.ProductName &&
                m.Amount == this.Amount && m.UnitPrice == this.UnitPrice;
        }
    }
}
