using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary
{
    public class Cart
    {
        public string CusId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<tblCake> list = new List<tblCake>();
        
        public Cart()
        {
        }
        public void addCake(string id,string name, float price)
        {
            tblCake Cake = list.Where(x => x.cakeId.Equals(id)).SingleOrDefault();
            if(Cake == null)
            {
                list.Add(new tblCake { cakeId = id, quantity = 1 ,price = price,name = name});

            }
            else
            {
                Cake.quantity += 1;
            }
        }
        public void deleteCake(string id)
        {
            tblCake Cake = list.Where(x => x.cakeId.Equals(id)).SingleOrDefault();
            list.Remove(Cake);
        }
        public void updateCake(string id,int quantity)
        {
            tblCake Cake = list.Where(x => x.cakeId.Equals(id)).SingleOrDefault();
            Cake.quantity = quantity;

        }

        public override string ToString()
        {
            string msg = "";
            foreach (tblCake item in list)
            {
                msg += item.cakeId + item.name + item.price + item.quantity + "\n";
            }
            return msg;
        }
    }
}
