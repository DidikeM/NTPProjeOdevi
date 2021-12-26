using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities.Dal
{
    class OrderDal : IRepository<Order>
    {
        public List<Order> GetAll()
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Orders.ToList();
            }
        }

        public Order GetByID(int ID)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Orders.FirstOrDefault(p => p.ID == ID);
            }
        }

        public List<Order> GetByCustomerID(int CustomerID)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Orders.Where(p => p.CustomerID == CustomerID).ToList();
            }
        }

        public void Add(Order order)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public void Update(Order order)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(order);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delate(Order order)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(order);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
