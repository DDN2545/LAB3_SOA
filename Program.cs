using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
            numberconvert.NumberConversion nc = new numberconvert.NumberConversion();
            Console.WriteLine(nc.NumberToWords(11));
            Console.ReadKey();
    }
}