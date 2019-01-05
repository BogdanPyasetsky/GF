using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF
{
    class NBNumber
    {
        private int[] num = null;

        public NBNumber()
        {
            num = new int[1];
        }

        public NBNumber(int a)
        {
            num = new int[a];
        }

        public NBNumber(string a)
        {
            num = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                num[i] = Convert.ToByte(a.Substring(i, 1), 2);
        }

        public string BitSTR()
        {
            string res = "";
            for (int i = 0; i < num.Length; i++)
                res = res + Convert.ToString(num[i], 2);
            return res;
        }

        public int GetBit(int i)
        {
            int res = num[i];
            return res;
        }

        public int GetLength()
        {
            return num.Length;
        }

        public void SetBit(int x, int i)
        {
            num[i] = x;
        }

        public static NBNumber LeftCycle(NBNumber a)
        {
            NBNumber res = new NBNumber(a.GetLength());
            res.SetBit(a.GetBit(0), a.GetLength() - 1);
            for (int i = 1; i < a.GetLength(); i++)
                res.SetBit(a.GetBit(i), i - 1);
            return res;
        }
    }
}