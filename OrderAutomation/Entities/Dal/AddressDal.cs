using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities.Dal
{
    class AddressDal : IRepository<Address>
    {
        public List<Address> GetAll()
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Addresses.ToList();
            }
        }

        public Address GetByID(int ID)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Addresses.FirstOrDefault(p => p.ID == ID);
            }
        }

        public void Add(Address address)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                context.Addresses.Add(address);
                context.SaveChanges();
                //var entity = context.Entry(address);
                //entity.State = EntityState.Added;
                //context.SaveChanges();
            }
        }

        public void Update(Address address)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(address);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delate(Address address)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(address);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
