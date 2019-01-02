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
            int l = a.GetLength() - b.GetLength();
            var c = b.SetLength(8);
            
            Console.WriteLine(a.BitSTR());
            Console.WriteLine(c.BitSTR());
            Console.ReadKey();
                        
        }


    }
}
