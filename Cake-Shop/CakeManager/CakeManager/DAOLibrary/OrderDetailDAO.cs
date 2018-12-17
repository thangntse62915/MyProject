using System.Collections.Generic;
using System.Linq;
namespace DAOLibrary
{
    public class OrderDetailDAO
    {
        CakeShopEntities ctx;

        public OrderDetailDAO()
        {
            ctx = new CakeShopEntities();
        }

        public OrderDetailDAO(CakeShopEntities ctx)
        {
            this.ctx = ctx;
        }
        public IEnumerable<tblOrderDetail> GetOrderDetail(int orderId)
        {
            return (from o in ctx.tblOrderDetails where o.orderId == orderId select o).ToList();
        }
    }
}
