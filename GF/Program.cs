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
            PBNumber a = new PBNumber("01001100");
            PBNumber b = new PBNumber("1010");
            /*var v = PBOperatoins.Mul(a, b);                    
            var c1 = a.Shift(3);
            var c2 = a.Shift(1);
            var c = PBOperatoins.Add(c1, c2);
            Console.WriteLine(c1.BitSTR());
            Console.WriteLine("  "+c2.BitSTR());
            Console.WriteLine(c.BitSTR());
            Console.WriteLine(v.BitSTR());
            */
            var c = a.CutZeros();
            Console.WriteLine(c.BitSTR());
            Console.ReadKey();
                        
        }


    }
}
