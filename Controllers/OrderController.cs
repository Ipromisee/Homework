using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using OrderApp;

namespace Assignment9.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrderController:ControllerBase
    {
        private readonly OrderService orderService;
        // 构建函数把OrderContext作为参数，Asp.net core框架可以自动注入OrderContext对象
        public OrderController(OrderService service)
        {
            this.orderService = service;
        }
        [HttpGet]//GET
        public ActionResult<List<Order>> GetOrders()
        {
            return orderService.GetAllOrders();
        }
        [HttpGet("{id}")]//GET:api/order/id
        public ActionResult<Order> GetOrder(string id)
        {
            Order order = orderService.GetOrder(id);
            // 没找到返回NotFound
            if(order == null)
            {
                return NotFound();
            }
            return order;
        }
        [HttpPost]
        public ActionResult<Order> AddOrder(Order order)
        {
            try
            {
                //需要为其加一个id
                order.OrderId = Guid.NewGuid().ToString();
                orderService.AddOrder(order);
                //orderService.AddOrder(order);
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }
        [HttpPut("{id}")]//通过PUT修改
        public ActionResult<Order> putOrder(string id,Order order)
        {
            if(id!=order.OrderId)
            {
                return BadRequest("ID cannot be modified");
            }
            try
            {
                orderService.UpdateOrder(order);
            }
            catch(Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();//没有返回消息
        }
        [HttpDelete("{id}")]
        public ActionResult<Order> DeleteOrder(string id)
        {
            try 
            {
                orderService.RemoveOrder(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}