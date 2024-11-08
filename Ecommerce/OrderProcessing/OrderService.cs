using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class OrderService: IOrderService
    {
        List<Order> _ordersList;

        public OrderService()
        {
            _ordersList = new List<Order>();
        }
        public bool Delete(Order order)
        {
            return this._ordersList.Remove(order);
        }

        public List<Order> GetAllOrders()
        {
            return _ordersList;
        }

        public Order GetById(int id)
        {
            foreach (Order order in _ordersList)
            {
                if (order.Id == id) return order;
            }
            return null;
        }

        public bool Insert(Order order)
        {
            this._ordersList.Add(order);
            return true;
        }

        public bool Update(Order order)
        {
            Order thisOrder = this.GetById(order.Id);
            thisOrder.Date = order.Date;
            thisOrder.Amount = order.Amount;
            thisOrder.Status = order.Status;
            return true;
        }
    }
}
