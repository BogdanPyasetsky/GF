using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GF
{
    class PBOperatoins
    {
        public static PBNumber Add(PBNumber a, PBNumber b)
        {
            int len1 = a.GetLength();
            int len2 = b.GetLength();
            PBNumber res = new PBNumber(Math.Max(len1, len2));
            int temp;
            for (int i = 0; i < Math.Min(len1, len2); i++)
            {
                temp = a.GetBit(i) + b.GetBit(i);
                if (temp == 2)
                    temp = 0;
                res.SetBit(temp, i);
            }
            if (len1 > len2)
                for (int i = Math.Min(len1, len2); i < Math.Max(len1, len2); i++)
                {
                    res.SetBit(a.GetBit(i), i);
                }
            else
                for (int i = Math.Min(len1, len2); i < Math.Max(len1, len2); i++)
                {
                    res.SetBit(b.GetBit(i), i);
                }

            return res;
        }

        public static PBNumber Mul(PBNumber a, PBNumber b)
        {
            int len = a.GetLength();
            PBNumber res = new PBNumber();
            PBNumber gen = new PBNumber("100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000101011");
            for (int i = 0; i < len; i++)
            {
                if(b.GetBit(i) == 1)
                    res = Add(res, a.Shift(i));
            }
            if (res.GetLength() < gen.GetLength())
                return res;
            else
            {

            }

            
            return res;
        }
    }
}
