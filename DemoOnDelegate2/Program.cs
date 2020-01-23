using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnDelegate2
{

    public delegate double calAreaPointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            //Method reference directly
            calAreaPointer cptr1 = new calAreaPointer(calArea);

            /*Anonymous method 
            calAreaPointer cptr = new calAreaPointer(delegate  (double r)
                                                     {
                                                     return (3.14 * r * r);
                                                     }
                                                     );
            double area = cptr(12);
            Console.WriteLine(area);
            */

            //Lambda Expression  (Simplified form of above code)

            calAreaPointer cptr = (r => 3.14 * r * r);
            double area = cptr(10);
            Console.WriteLine(area);
            Console.ReadKey();
        }
            public static double calArea(double r)
            {
                return 3.14 * r * r;
            }
            
        }
    }

