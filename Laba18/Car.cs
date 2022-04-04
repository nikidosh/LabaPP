using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba18
{
    class Car
    {
        double maxSpeed;
        string color;
        string producer;
        int countOfPassagers;

        public Car(double maxSpeed, string color, string producer, int countOfPassagers)
        {
            this.maxSpeed = maxSpeed;
            this.color = color;
            this.producer = producer;
            this.countOfPassagers = countOfPassagers;
        }

        public override string ToString()
        {
            return maxSpeed.ToString() + color.ToString() + producer.ToString() + countOfPassagers.ToString();
        }

        public void FindAudi(List<Car> list)
        {
            var zxc = from t in list
                      where t.producer.Contains("Audi")
                      select t;
            foreach (var item in zxc)
            {
                Console.WriteLine(item);
            }
        }
    }
}
