using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF
{
    class PBNumber
    {
        private int[] num = null;
        
        public PBNumber()
        {
            num = new int[1];
        }

        public PBNumber(int a)
        {
            num = new int[a];
        }

        public PBNumber(string a)
        {
            num = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                num[i] = Convert.ToByte(a.Substring(a.Length - (1 + i), 1), 2);                    
        }

        public string BitSTR()
        {
            string res = "";
            for (int i = 0; i < num.Length; i++)
                res = Convert.ToString(num[i], 2) + res;
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

        public PBNumber Shift(int t)
        {
            PBNumber res = new PBNumber(num.Length + t);
            for (int i = 0; i < num.Length; i++)
                res.SetBit(num[i], i + t);
            return res;
        }

        public PBNumber CutZeros()
        {
            int t = 0;
            int r = num.Length - 1;
            while (num[r] == 0)
            {
                r--;
                t++;
            }
            PBNumber res = new PBNumber(num.Length - t);
            for (int i = 0; i < num.Length - t; i++)
                res.SetBit(num[i], i);
            return res;
        }
    }
}
