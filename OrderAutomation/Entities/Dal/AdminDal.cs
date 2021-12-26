using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities.Dal
{
    class AdminDal : IRepository<Admin>
    {
        public List<Admin> GetAll()
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Admins.ToList();
            }
        }

        public Admin GetByID(int ID)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Admins.FirstOrDefault(p => p.ID == ID);
            }
        }

        public Admin GetByUsername(string username)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Admins.FirstOrDefault(p => p.Username == username);
            }
        }

        public bool CheckByLogin(string username, string password)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                if (context.Admins.FirstOrDefault(p => p.Username == username && p.Password == password) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Add(Admin admin)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                context.Admins.Add(admin);
                context.SaveChanges();
            }
        }

        public void Update(Admin admin)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(admin);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delate(Admin admin)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(admin);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
