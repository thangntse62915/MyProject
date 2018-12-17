using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary
{
    
    public class CakeDAO
    {
        CakeShopEntities ctx;
      

        public CakeDAO()
        {
            ctx = new CakeShopEntities();
        }

        public CakeDAO(CakeShopEntities ctx)
        {
            this.ctx = ctx;
        }
        public IEnumerable<tblCake> SearchCake(string value,bool isID)
        {if(isID == true)
            {
                
                return ctx.tblCakes.Where(x => x.status == true && x.cakeId.Equals(value)).ToList();

            }
            else
            {
                return ctx.tblCakes.Where(x => x.status == true && x.name.Contains(value)).ToList();
            }
            
        }

        public void UpdateEmployy(Employee Em, int id)
        {
            Employee OldEm = (from e in ctx.Employees where e.id.Equals(id) select e).SingleOrDefault();
            OldEm.name = Em.name;
            OldEm.phone = Em.phone;
            OldEm.Card = Em.Card;
            OldEm.gender = Em.gender;
            OldEm.birthday = Em.birthday;
            OldEm.address = Em.address;
            OldEm.password = Em.password;
            if (Em.Image != null)
            {
                OldEm.Image = Em.Image;
            }
            ctx.SaveChanges();
        }
        public Employee checkLogin(String username, String password)
        {
            Employee em = (from e in ctx.Employees where e.username.Equals(username) && e.password.Equals(password) select e).SingleOrDefault();
            return em;
        }

    }
}
