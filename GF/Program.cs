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
            NBNumber a = new NBNumber("101011");
            NBNumber b = new NBNumber("110001");
            var c = NBOperations.Mul(a,b);
            
            Console.WriteLine(c.BitSTR());
            Console.WriteLine();

            Console.ReadKey();
                        
        }


    }
}
