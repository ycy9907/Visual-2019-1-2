using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A020_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(3);
            a.Add(13);
            a.Add(32);
            a.Add(31);
            a.Add(25);
            a.Add(64);
            a.Add(37);
            a.Add(86);
            a.Add(56);
            a.Add(98);

            a.Sort();
            foreach(var item in a)
            {
                Console.WriteLine(item);
            }

        }
    }
}
