using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities.Dal
{
    class TaxDal:IRepository<Tax>
    {
        public List<Tax> GetAll()
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Taxes.ToList();
            }
        }

        public Tax GetByID(int ID)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Taxes.FirstOrDefault(p => p.ID == ID);
            }
        }

        public void Add(Tax tax)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                context.Taxes.Add(tax);
                context.SaveChanges();
            }
        }

        public void Update(Tax tax)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(tax);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delate(Tax tax)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(tax);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
