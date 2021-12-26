using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities.Dal
{
    class OrderDetailDal : IRepository<OrderDetail>
    {
        public List<OrderDetail> GetAll()
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.OrderDetails.ToList();
            }
        }

        public OrderDetail GetByID(int ID)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.OrderDetails.FirstOrDefault(p => p.ID == ID);
            }
        }

        public List<OrderDetail> GetByOrderID(int OrderID)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.OrderDetails.Where(p => p.OrderID == OrderID).ToList();
            }
        }

        public void Add(OrderDetail orderDetail)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                context.OrderDetails.Add(orderDetail);
                context.SaveChanges();
            }
        }

        public void Update(OrderDetail orderDetail)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(orderDetail);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delate(OrderDetail orderDetail)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(orderDetail);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
