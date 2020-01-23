using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DemoOnBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary Writer writes into file in the binary format
            /*
            FileStream fs = new FileStream(@"E:\Pranavi\mydir2\b.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            int i = 10;
            char c = 'w';
            string f = "hello";
            bw.Write(i);
            bw.Write(c);
            bw.Write(f);

            bw.Close();
            fs.Close();
 
           */

            //Binary Reader reads the data in file in the binary format so we shud read in our own format using read methods

             FileStream fs1 = new FileStream(@"E:\Pranavi\mydir2\b.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs1);
            int ij = br.ReadInt32();
            char ch = br.ReadChar();
            string fg = br.ReadString();
            

            br.Close();
            fs1.Close();
            Console.WriteLine(ij + " " + ch + " " + " " + fg);
         
            Console.ReadKey();
        }
    }
}
