using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TL1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var g = new HashSet<string>();
            g.Add("a");
            g.Add("b");
            g.Add("c");
            g.Add("d");
            g.Add("a");
            foreach (var item in g)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("so pt : "+g.Count);
            var l = new List<string>();
            l.Add("Liên minh ht");
            l.Add("Genshin impact");
            l.Add("GTA 5");
            l.Insert(1, "CSO");
            l.Remove("GTA 5");
            l.Sort();
            var check = l.Contains("GTA 5");
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(check);

        }
    }
}
