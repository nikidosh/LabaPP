using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba18
{
    class Tovar
    {
        string name;
        double weight;
        double price;
        int category;

        public Tovar(string name, double weight, double price, int category)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
            this.category = category;
        }

        public void Average(List<Tovar> ab)
        {
          
            int count = 0;
            int count1 = 0;
            foreach (var bb in ab)
                if(bb.category==1)
                count++;
            foreach (var bb in ab)
                if (bb.category == 2)
                    count1++;
            var result = from t in ab
                         group t by t.category;
            
            foreach(var bb in result)
            {
                var zxc = (bb.Sum(x => x.price)) / count;
                var zxc1 = (bb.Sum(x => x.price)) / count1;
                Console.WriteLine($"Sum = {zxc.ToString(CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Sum = {zxc1.ToString(CultureInfo.InvariantCulture)}");
            }


        }
    }
}
