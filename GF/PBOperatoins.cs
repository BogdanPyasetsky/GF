using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GF
{
    class PBOperatoins
    {
        public static PBNumber GetONE()
        {
            PBNumber gen = new PBNumber("100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000101011");
            PBNumber res = new PBNumber("1");
            res = res.SetLength(gen.GetLength() - 1);
            return res;
        }

        public static PBNumber GetZERO()
        {
            PBNumber gen = new PBNumber("100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000101011");
            PBNumber res = new PBNumber(gen.GetLength() - 1);
            return res;
        }

        public static PBNumber Add(PBNumber a, PBNumber b)
        {
            int len1 = a.GetLength();
            int len2 = b.GetLength();
            PBNumber res = new PBNumber(Math.Max(len1, len2));
            int temp;
            for (int i = 0; i < Math.Min(len1, len2); i++)
            {
                temp = a.GetBit(i) ^ b.GetBit(i);
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
            int len = b.GetLength();
            PBNumber res = new PBNumber();
            PBNumber gen = new PBNumber("100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000101011");
            int glen = gen.GetLength(); //generator's string length
            int l;                      // length difference
            for (int i = 0; i < len; i++)
            {
                if(b.GetBit(i) == 1)
                    res = Add(res, a.Shift(i));
            }
            while (res.GetLength() >= glen)
            {
                res = res.CutZeros();
                l = res.GetLength() - glen;
                res = Add(res, gen.Shift(l));
                res = res.CutZeros();
            }
            res = res.SetLength(glen - 1);            
            return res;
        }

        public static PBNumber Sqr(PBNumber a)
        {
            PBNumber res = new PBNumber(a.GetLength() * 2 - 1);
            PBNumber gen = new PBNumber("100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000101011");
            int glen = gen.GetLength(); //generator's string length
            int l;                      // length difference
            for (int i = 0; i < a.GetLength(); i++)
            {
                res.SetBit(a.GetBit(i), 2 * i);
            }
            while (res.GetLength() >= glen)
            {
                res = res.CutZeros();
                l = res.GetLength() - glen;
                res = Add(res, gen.Shift(l));
                res = res.CutZeros();
            }
            res = res.SetLength(glen - 1);
            return res;
        }
        
        public static PBNumber Pow(PBNumber a, PBNumber n)
        {
            PBNumber res = new PBNumber("1");
            res = res.SetLength(a.GetLength());
            PBNumber gen = new PBNumber("100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000101011");
            int glen = gen.GetLength(); //generator's string length
            int l;                      // length difference
            for (int i = n.GetLength() - 1; i > 1; i--)
            {
                if (n.GetBit(i) == 1)
                    res = Mul(res, a);
                res = Sqr(res);
            }
            if (n.GetBit(0) == 1)
                res = Mul(res, a);
            while (res.GetLength() >= glen)
            {
                res = res.CutZeros();
                l = res.GetLength() - glen;
                res = Add(res, gen.Shift(l));
                res = res.CutZeros();
            }
            res = res.SetLength(glen - 1);
            return res;
        }
    }
}
