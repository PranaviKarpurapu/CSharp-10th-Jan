using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnDelegate
{
    public delegate void delegatePointer();  //delegate definition

    public delegate double calAreaPointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
            Program p = new Program();
            delegatePointer mydel = p.print;
            mydel += p.display;      //multicast delegate without returntype,parameters     
            mydel();
            mydel -= p.print;         //removing delegate reference
            mydel();

            calAreaPointer cptr = Calculate.calArea;
            //double area = cptr(20);
            //Console.WriteLine("Area : "+area);

            cptr += Calculate.calDist;   //multicast delegate with returntype,parameters 
            double dist = cptr(32);
            Console.WriteLine("Distance : " + dist);



            Console.ReadKey();
        }
        public void print()
        {
            Console.WriteLine("\nWelcome to delegate\n");
        }
        public void display()
        {
            Console.WriteLine("\nWelcome to  multicast delegate\n");
        }
    }
}
