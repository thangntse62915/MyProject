﻿using System.Collections.Generic;
using System.Linq;

namespace DAOLibrary
{
    public class OrderDAO
    {
        CakeShopEntities ctx;

        public OrderDAO()
        {
            ctx = new CakeShopEntities();
        }

        public OrderDAO(CakeShopEntities ctx)
        {
            this.ctx = ctx;
        }
        public IEnumerable<tblOrder> GetAllOrder()
        {
            return (from o in ctx.tblOrders select o).ToList();
        }
        public bool AcceptOrder(string orderId)
        {
            var o = ctx.tblOrders.Find(orderId);
            if (o.status != true)
            {
                o.status = true;
            }
            else
            {
                return false;
            }
            foreach (var temp in o.tblOrderDetails)
            {
                temp.tblCake.quantity--;
                temp.tblCake.bought++;
            }
            return ctx.SaveChanges() == 1;
        }
        public bool RejectOrder(string orderId)
        {
            var o = ctx.tblOrders.Find(orderId);
            o.status = false;
            return ctx.SaveChanges() == 1;
        }
        public IEnumerable<tblOrder> SearchOrder(int orderId)
        {
            return (from o in ctx.tblOrders where o.orderID == orderId select o).ToList();
        }
        public string createOrder(string idCus, List<tblCake> Cakes)
        {
            string result = "";
            tblCustomer Customer = ctx.tblCustomers.Where(x => x.customerId.Equals(idCus)).SingleOrDefault();
            if (Customer == null)
            {
                result = "NotValid";

            }
            else
            {
               int NorderId = ctx.tblOrders.Add(new tblOrder { cusID = idCus, address = Customer.address, phone = Customer.phone, status = true }).orderID;
                foreach (tblCake item in Cakes)
                {
                    ctx.tblOrderDetails.Add(new tblOrderDetail { orderId = NorderId, cakeId = item.cakeId, quantity = item.quantity });
 
                }
                ctx.SaveChanges();
            }
            
            return result;
        }
    }
}
