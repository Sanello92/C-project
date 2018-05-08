using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new MyCollection(new int[4]{13, 123, 3, 1342});

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
