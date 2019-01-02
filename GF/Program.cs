using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF
{
    class Program
    {
        static void Main(string[] args)
        {
            PBNumber a = new PBNumber("010011001");
            PBNumber b = new PBNumber("10");
            //var c = PBOperatoins.Pow(a, b);
            //var c = PBOperatoins.Sqr(b);
            Console.WriteLine(a.GetLength());
            for (int i = a.GetLength() - 1; i > 1; i--)
            {
                Console.Write(a.GetBit(i) + " | ");
            }
            Console.WriteLine(a.GetBit(0));
            
            Console.ReadKey();
                        
        }


    }
}
