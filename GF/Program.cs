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
            //var c = NBOperations.SqrPow(b, 2);
            var d = Convert.ToString(430, 2);
            //Console.WriteLine(c.BitSTR());
            //Console.WriteLine(d[2]);

            Console.ReadKey();
                        
        }


    }
}
