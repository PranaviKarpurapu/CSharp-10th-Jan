using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoOnDelegate3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Prebuild delegates Func<>,Action<>,Predicate<>

            Func<double, double> f1 = (r => 3.14 * r * r);
            double area = f1(10);
            Console.WriteLine("Area: " +area);

            Action<string> act = (xy => Console.WriteLine("Action :"+xy));
            act("Welcome");

            Predicate<string> p = (y => y.Length > 3);
            Console.WriteLine("(Length of string >3) ? "+p("Banglore"));

            int[] array = new int[] { 1, 2, 3, 4,5 };
            List<string> names = new List<string>();
            names.Add("ab");
            names.Add("abc");
            names.Add("abcd");
            int x = array.Count( x1 => x1 > 4);
            Console.WriteLine("Count: "+x);

            List<string> sn=names.FindAll(y1 => y1.Contains('c'));
            foreach(string str in sn)
            {
                Console.WriteLine("Strings which contains c :"+str);
            }
            Console.ReadKey();

        }
    }
}
