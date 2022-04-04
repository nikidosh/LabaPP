using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba18
{
    class Product
    {
        string name;
        int count;
        string description;

        public Product(string name, int count, string description)
        {
            this.name = name;
            this.count = count;
            this.description = description;
        }

        public override string ToString()
        {
            return name.ToString() + count.ToString() + description.ToString();
        }

        public void FindProduct(List<Product> zxc)
        {
            var zx = from t in zxc
                     where t.count ==0
                     select t;
            foreach (var item in zx)
            {
                Console.WriteLine(item);
            }
        }
    }
}
