using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GF
{
    class NBOperations
    {

        public static NBNumber GetONE()
        {
            NBNumber res = new NBNumber(431);
            for (int i = 0; i < 431; i++)
                res.SetBit(1, i);
            return res;
        }

        public static PBNumber GetZERO()
        {
            PBNumber res = new PBNumber(431);
            return res;
        }

        public static NBNumber Add(NBNumber a, NBNumber b)
        {
            int len1 = a.GetLength();
            int len2 = b.GetLength();
            NBNumber res = new NBNumber(Math.Max(len1, len2));
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

        public static NBNumber Sqr(NBNumber a)
        {
            NBNumber res = new NBNumber(a.GetLength());
            res.SetBit(a.GetBit(a.GetLength()-1),0);
            for (int i = 0; i < a.GetLength() - 1; i++)
                res.SetBit(a.GetBit(i), i+1);
            return res;
        }

        public static NBNumber SqrPow(NBNumber a, int k)
        {
            NBNumber res = a;
            for(int i = 0; i < k; i++)
                res = Sqr(res);
            return res;
        }

        public static int Trace(NBNumber a)
        {
            int res = a.GetBit(0);
            for (int i = 1; i < a.GetLength(); i++)
            {
                res = res ^ a.GetBit(i);
            }
            return res;
        }

        public static int[,] Lambda(int m)
        {
            int p = 2 * m + 1;
            int[,] Lam = new int[m, m];
            int[] TP = new int[m];
            int TPi, TPj;
            TP[0] = 1;
            for (int i = 1; i < m; i++)
                TP[i] = (TP[i - 1] * 2) % p;
            for(int i = 0; i < m; i++)
            {
                TPi = TP[i];
                for(int j = 0; j < m; j++)
                {
                    TPj = TP[j];
                    if (((TPi + TPj) % p == 1) || ((TPi - TPj + p) % p == 1) || ((-TPi + TPj + p) % p == 1) || ((-TPi - TPj + p) % p == 1))
                        Lam[i, j] = 1;
                    else
                        Lam[i, j] = 0;
                }
            }
            return Lam;
        }

        public static NBNumber Mul(NBNumber a, NBNumber b)
        {
            int m = a.GetLength();
            NBNumber res = new NBNumber(m);
            int[] temparr = new int[m];
            int temp;
            var ta = a; var tb = b;
            var Lam = Lambda(m);
            for(int k = 0; k < m; k++)
            {
                for(int j = 0; j < m; j++)
                {
                    temparr[j] = ta.GetBit(0) * Lam[0, j];
                    for (int i = 1; i < m; i++)
                    {
                        temparr[j] = temparr[j] ^ (ta.GetBit(i) * Lam[i, j]);
                    }
                }
                temp = temparr[0] * tb.GetBit(0);
                for (int i = 1; i < m; i++)
                {
                    temp = temp ^ temparr[i] * tb.GetBit(i);
                }
                res.SetBit(temp, k);
                ta = NBNumber.LeftCycle(ta);
                tb = NBNumber.LeftCycle(tb);
            }
            return res;
        }

        public static NBNumber Pow(NBNumber a, NBNumber n)
        {
            NBNumber res = GetONE();
            for (int i = 0; i < n.GetLength() - 1; i++)
            {
                if (n.GetBit(i) == 1)
                    res = Mul(res, a);
                res = Sqr(res);
            }
            if (n.GetBit(n.GetLength() - 1) == 1)
                res = Mul(res, a);
            return res;
        }
        
        public static NBNumber Reverce(NBNumber a)
        {
            NBNumber res = new NBNumber(a.GetLength());
            NBNumber b = a;
            int k = 1;
            var bin = Convert.ToString(a.GetLength() - 1, 2);
            for (int i = 1; i < bin.Length; i++)
            {
                b = Mul(SqrPow(b,k),b);
                k = 2 * k;
                if(bin[i] == '1')
                {
                    b = Mul(Sqr(b), a);
                    k = k + 1;
                }
            }
            res = Sqr(b);
            return res;
        }
    }
}
