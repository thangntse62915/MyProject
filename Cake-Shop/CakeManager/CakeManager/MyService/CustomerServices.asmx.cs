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
        CakeShopEntities ctx;
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
