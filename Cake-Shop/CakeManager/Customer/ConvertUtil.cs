using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer
{
    public class ConvertUtil
    {
        public static localhost.tblCustomer ConvertLDC(DAOLibrary.tblCustomer cus)
        {
            localhost.tblCustomer convert = new localhost.tblCustomer();
            convert.customerId = cus.customerId;
            convert.address = cus.address;
            convert.phone = cus.phone;
            convert.fullname = cus.fullname;
            convert.email = cus.email;
            return convert;
        }
       
    }
}
