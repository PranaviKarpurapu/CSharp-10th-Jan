using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee();

            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("Pranavi", 48, 80000));
            elist.Add(new Employee("Riya", 485, 70000));
            elist.Add(new Employee("Swathi", 148, 60000));
            elist.Add(new Employee("Ajay", 478, 20000));

            List<Employee> highpay = elist.FindAll(e => e.sal > 90000);
            foreach(Employee el in highpay)
            {
                Console.WriteLine(el.ToString());
            }
            Console.ReadKey();
        }


    }
}
