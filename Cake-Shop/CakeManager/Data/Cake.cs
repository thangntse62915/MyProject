using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Cake
    {
        public string CakeId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Origin { get; set; }
        public int Quantity { get; set; }
        public byte[] Img1 { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Cake()
        {
        }

        public Cake(string cakeId, string name, float price, string origin, int quantity, byte[] img1, string categoryId,string description,string categoryName)
        {
            CakeId = cakeId;
            Name = name;
            Price = price;
            Origin = origin;
            Quantity = quantity;
            Img1 = img1;
            CategoryId = categoryId;
            Description = description;
            CategoryName = categoryName;
        }
        public Cake(string cakeId, string name, float price, string origin, int quantity, byte[] img1, string categoryId, string description)
        {
            CakeId = cakeId;
            Name = name;
            Price = price;
            Origin = origin;
            Quantity = quantity;
            Img1 = img1;
            CategoryId = categoryId;
            Description = description;
           
        }
    }
}
