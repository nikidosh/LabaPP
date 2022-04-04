using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba18
{
    class Program
    {
        public static void FindElementByO(string[] A)
        {
            var zxc = from t in A
                      where t.Contains('i')
                      select t;
            foreach (var item in zxc)
            {
                Console.WriteLine(item);
            }
        }
        public static void FindYellow(string[] C)
        {
            var zxc = from t in C
                      where t.Contains("Yellow")
                      select t;
            foreach (var item in zxc)
            {
                Console.WriteLine(item);
            }
        }
        public static void Repeat(List<string> myCars, List<string> yourCars)
        {
            var zxc = myCars.Except(yourCars);
            foreach (var item in zxc)
                Console.WriteLine(item);

        }
        static void Main(string[] args)
        {
            string[] A = { "Dota 2", "Mortak Kombat", "csgo", "Dark Souls", "Cyberpunk 2077","The Wither"  };
            FindElementByO(A);
            Console.WriteLine("-----");

            string[] C = { "Light Green", "Red", "Green", "Yellow", "Purple", "Dark Green", "Light Red", "Dark Red", "Dark Yellow", "Light Yellow" };
            FindYellow(C);
            Console.WriteLine("-----");

            List<string> myCars = new List<String> { "BMW", "Citroen", "Peugeot","Audi" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec","Audi" };
            Car B = new Car(220.9, "Blue", "BMW", 6);
            Car E = new Car(123.5, "Yellow", "Citroen", 20);
            Car Q = new Car(321.9, "Brown", "Peugeot", 4);
            Car P = new Car(123.5, "Black", "Audi", 2);
            List<Car> list1 = new List<Car>();
            list1.Add(B);
            list1.Add(E);
            list1.Add(Q);
            list1.Add(P);
            B.FindAudi(list1);
            Console.WriteLine("-----");   
            Product first = new Product("Milk", 0, "moloko");
            Product second = new Product("Mandarin", 0, "orange");
            Product third = new Product("arbuz", 100, "zelenoe o krasnoe");
            List<Product> list2=new List<Product>();
            list2.Add(first);
            list2.Add(second);
            list2.Add(third);
            first.FindProduct(list2);
            Console.WriteLine("-----");

            Repeat(myCars, yourCars);
            Console.WriteLine("-----");
            Tovar a = new Tovar("Fish", 0.783, 3.23, 1);
            Tovar b = new Tovar("Milk", 0.5, 2.99, 1);
            Tovar c = new Tovar("Coca-Cola", 1.5, 4.99, 2);
            List<Tovar> zxc = new List<Tovar>();
            zxc.Add(a);
            zxc.Add(b);
            zxc.Add(c);
            a.Average(zxc);
            
            Console.ReadKey();
        }
    }
}
