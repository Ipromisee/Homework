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
        // ����������OrderContext��Ϊ������Asp.net core��ܿ����Զ�ע��OrderContext����
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
            // û�ҵ�����NotFound
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
                //��ҪΪ���һ��id
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
        [HttpPut("{id}")]//ͨ��PUT�޸�
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
            return NoContent();//û�з�����Ϣ
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