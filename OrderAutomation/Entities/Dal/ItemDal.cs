using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities.Dal
{
    class ItemDal:IRepository<Item>
    {
        public List<Item> GetAll()
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Items.ToList();
            }
        }

        public Item GetByID(int ID)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Items.FirstOrDefault(p => p.ID == ID);
            }
        }

        public void Add(Item item)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                context.Items.Add(item);
                context.SaveChanges();
            }
        }

        public void Update(Item item)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(item);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delate(Item item)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(item);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
