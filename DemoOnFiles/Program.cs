using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DemoOnFiles
{
    class Program
    {
        static void Main(string[] args)
        {
           /* 1st Program Demo
            DirectoryInfo di = new DirectoryInfo(@"E:\Pranavi\mydir2");
            if(di.Exists==false)   //if directory does not exists it creates new file
            di.Create();
            di.CreateSubdirectory("mydir");
            DirectoryInfo[] d = di.GetDirectories();
            foreach(DirectoryInfo x in d)
            {
                Console.WriteLine(x.Name + " " + x.FullName + " " + x.CreationTime);
            }

            FileInfo[] fi = di.GetFiles();
            Console.WriteLine("\n\n****************************************************************\n");
            foreach (FileInfo x in fi)
            {
                Console.WriteLine(x.Name + " " + x.FullName + " " + x.CreationTime);
            }
            //Stream Writer
            FileStream fs = new FileStream(@"E:\Pranavi\mydir2\a.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Welcome");
            for(int i=0;i<2;i++)
            {
                string s = Console.ReadLine();
                sw.WriteLine(s);
            }
            sw.Close();
            fs.Close();

    */

            //Stream Reader   (2nd Program)

            FileStream fs1 = new FileStream(@"E:\Pranavi\mydir2\a.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs1);
            string s;
            while ((s = sr.ReadLine())!= null)
            {
                Console.WriteLine(s);
            }

            sr.Close();
            fs1.Close();

            Console.ReadKey();
        }
    }
}
