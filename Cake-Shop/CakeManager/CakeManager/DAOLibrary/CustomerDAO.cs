﻿using System.Collections.Generic;
using System.Linq;

namespace DAOLibrary
{
    public class CustomerDAO
    {
        CakeShopEntities ctx;

        public CustomerDAO()
        {
            ctx = new CakeShopEntities();
        }

        public CustomerDAO(CakeShopEntities ctx)
        {
            this.ctx = ctx;
        }
        public IEnumerable<tblCustomer> GetAllCustomer()
        {
            return ctx.tblCustomers.ToList();
        }
        public bool BanCustomer(string id)
        {
            var cus = (from c in ctx.tblCustomers where c.customerId.Equals(id) select c).FirstOrDefault();
            cus.enable = false;
            return ctx.SaveChanges() == 1;
        }
        public bool UnbanCustomer(string id)
        {
            var cus = (from c in ctx.tblCustomers where c.customerId.Equals(id) select c).FirstOrDefault();
            cus.enable = true;
            return ctx.SaveChanges() == 1;
        }
        public IEnumerable<tblCustomer> SearchCustomer(string fullname)
        {
            return (from c in ctx.tblCustomers where c.fullname.Contains(fullname) select c).ToList();
        }
        public string insertCustomer(tblCustomer cus)
        {
            tblCustomer c = ctx.tblCustomers.Where(x => x.customerId.Equals(cus.customerId)).SingleOrDefault();
            if (c != null) { return "Id"; }
             c = ctx.tblCustomers.Where(x => x.phone.Equals(cus.phone)).SingleOrDefault();
            if (c != null) { return "Phone"; }
            ctx.tblCustomers.Add(cus);
            ctx.SaveChanges();
            return "";
        }
    }
}
