using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DemoOnThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started");
            ThreadClass tc = new ThreadClass();
            Thread th1 = new Thread(tc.countEven);
            Thread th2 = new Thread(tc.countOdd);

            //to set priority to threads
           // th1.Priority = ThreadPriority.Lowest;
            //th2.Priority = ThreadPriority.Highest;

            //thread moves to runnable state
            th1.Start();
            th2.Start();




          //  if (!th1.IsAlive)
          //      th1.Interrupt();  //forcefully stops from sleep state

            
            /* th1.Suspend();    //Suspend() is deprecated
            Console.WriteLine("Thread got suspended");   
            th1.Resume();
              */  
            
            
            Console.WriteLine("Main Ended");

            Console.ReadKey();
        }
    }
}
