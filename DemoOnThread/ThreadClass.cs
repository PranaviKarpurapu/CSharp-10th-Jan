using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DemoOnThread
{
    class SyncClass
    {
        public void print(int x)
        {
            for (int i = 0; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
       public  class ThreadClass
        {
            SyncClass sc = new SyncClass();
            public void countEven()
            {
               
                //lock this
               // Monitor.Enter(this);
                {
                    sc.print(10);
                }
                //Monitor.Exit(this);

                /*for (int i = 0; i < 100; i += 2)
                {
                    Console.WriteLine(i);
                   // if (i == 50)
                      //  Thread.Sleep(5000);
                    // Thread.Sleep(0);  //timeslice of this thread will be given to CountOdd()
                }
                */
            }


            public void countOdd()
            {
                
                //lock this
                Monitor.Enter(this);
                {
                    sc.print(20);
                }
                Monitor.Exit(this);

                /* for (int i = 1; i < 100; i += 2)
                 {
                     Console.WriteLine(i);
                 }
             }*/
            }
        }
    }

