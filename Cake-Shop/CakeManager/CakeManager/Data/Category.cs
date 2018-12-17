using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Category()
        {
        }

        public Category(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Id;
        }
    }
}
