using DAOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyService
{
    /// <summary>
    /// Summary description for CustomerServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CustomerServices : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public tblCustomer checkLogin(string username, string password)
        {
            CustomerDAO dao = new CustomerDAO();
            return dao.checkLogin(username, password);
        }
        [WebMethod]
        public string register(tblCustomer c)
        {
            CustomerDAO dao = new CustomerDAO();
            return dao.insertCustomer(c);
        }
        [WebMethod]
        public string checkListOrder(List<tblCake> list)
        {
            CakeShopEntities ctx = new CakeShopEntities();
            foreach (tblCake item in list)
            {
                tblCake cake = ctx.tblCakes.Where(x => x.cakeId.Equals(item.cakeId)).SingleOrDefault();
                if (cake.quantity < item.quantity)
                {
                    return item.name;
                }
            }
            return "";
        }
        [WebMethod]
        public void insertOrder(tblCustomer customer,List<tblCake> list)
        {
            CakeShopEntities ctx = new CakeShopEntities();
            tblOrder order = new tblOrder { cusID = customer.customerId, address = customer.address, phone = customer.phone, status = null };
            order= ctx.tblOrders.Add(order);
            ctx.SaveChanges();
            int orderi =  order.orderID;
            foreach (tblCake item in list)
            {
                ctx.tblOrderDetails.Add(new tblOrderDetail { orderId = orderi, cakeId = item.cakeId, quantity = item.quantity });
            }
            ctx.SaveChanges();
        }
        
    }
}
