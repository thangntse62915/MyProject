using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary
{
    public class EmployeeDAO
    {
        CakeShopEntities ctx { get; set; }

        public EmployeeDAO()
        {
            ctx = new CakeShopEntities();
        }
        public IEnumerable<Employee> GetAllEmployyee()
        {
            return ctx.Employees.Where(x => x.status == true && x.role.Equals("Employee")).ToList();
        }
        public void DeleteEmployee(int id)
        {
            var Em = (from e in ctx.Employees where e.id.Equals(id) select e).SingleOrDefault();
            Em.status = false;
            ctx.SaveChanges();

        }
        public IEnumerable<Employee> SearchEmployee(string fullname)
        {
            IEnumerable<Employee> list = (from e in ctx.Employees
                                          where e.name.Contains(fullname) && e.status == true  && e.role.Equals("Employee")
                                          select e).ToList();
            return list;
        }
        public void AddEmployee(Employee e)
        {
            ctx.Employees.Add(e);

            ctx.SaveChanges();
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
            Employee em = (from e in ctx.Employees where e.username.Equals(username) && e.password.Equals(password) && e.status == true && e.role.Equals("Employee") select e ).SingleOrDefault();
            return em;
        }
        public Employee checkAdminLogin(String username, String password)
        {
            Employee em = (from e in ctx.Employees where e.username.Equals(username) && e.password.Equals(password) && e.status == true select e).SingleOrDefault();
            return em;
        }
        public void UpdatePassowrd(string username,string password)
        {
            Employee e = ctx.Employees.Where(x => x.username.Equals(username)).SingleOrDefault();
            e.password = password;
            ctx.SaveChanges();
        }
        
    }
}
