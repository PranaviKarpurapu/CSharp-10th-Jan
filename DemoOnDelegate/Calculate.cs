using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnDelegate
{
   static class Calculate  //declared static instead of creating object
    {
        public static double calArea(double r)
        {
            return r*3.14 * r;
        }

        public static double calDist(double d)
        {
            return d * 100 ;
        }
    }
}
