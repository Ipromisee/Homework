using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;

namespace OrderApp {

    public class OrderService {

        //the order list
        //private List<Order> orders;
        OrderContext ctx;

        public OrderService(OrderContext context)
        {
            this.ctx = context;
        }

        public List<Order> GetAllOrders()
        {
            return ctx.Orders
                .Include(o => o.Details)
                .ThenInclude(d => d.GoodsItem)
                .Include(o => o.Customer)
                .ToList<Order>();
        }

        public Order GetOrder(string id)
        {
            return ctx.Orders
                .Include(o => o.Details.Select(d => d.GoodsItem))
                .Include(o => o.Customer)
                .SingleOrDefault(o => o.OrderId == id);
        }

        public void AddOrder(Order order)
        {
            FixOrder(order);
            ctx.Entry(order).State = EntityState.Added;
            ctx.SaveChanges();
        }

        public void RemoveOrder(string orderId)
        {
            var order = ctx.Orders.Include("Details")
                .SingleOrDefault(o => o.OrderId == orderId);
            if (order == null) return;
            ctx.OrderDetails.RemoveRange(order.Details);
            ctx.Orders.Remove(order);
            ctx.SaveChanges();
        }

        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            return ctx.Orders
                .Include(o => o.Details.Select(d => d.GoodsItem))
                .Include(o => o.Customer)
                .Where(order => order.Details.Any(item => item.GoodsItem.Name == goodsName))
                .ToList();
        }

        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            return ctx.Orders
                   .Include(o => o.Details.Select(d => d.GoodsItem))
                   .Include(o => o.Customer)
                   .Where(order => order.Customer.Name == customerName)
                   .ToList();
        }

        public void UpdateOrder(Order newOrder)
        {
            RemoveOrder(newOrder.OrderId);
            AddOrder(newOrder);
        }

        //避免级联添加或修改Customer和Goods
        private static void FixOrder(Order newOrder)
        {
            newOrder.CustomerId = newOrder.Customer.Id;
            newOrder.Customer = null;
            newOrder.Details.ForEach(d => {
                d.GoodsId = d.GoodsItem.Id;
                d.GoodsItem = null;
            });
        }

        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create)) {
                xs.Serialize(fs, GetAllOrders());
            }
        }

        public void Import(string path) {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open)) {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order => {
                    if (ctx.Orders.SingleOrDefault(o=>o.OrderId==order.OrderId)==null) {
                        FixOrder(order);
                        ctx.Orders.Add(order);
                    }
                });
            ctx.SaveChanges();
            }
        }

        public object QueryByTotalAmount(float amout) {
            return ctx.Orders
                .Include(o => o.Details.Select(d => d.GoodsItem))
                .Include("Customer")
                .Where(order=>order.Details.Sum(d=>d.Quantity*d.GoodsItem.Price)>amout)
                .ToList();
        }
    }
}
