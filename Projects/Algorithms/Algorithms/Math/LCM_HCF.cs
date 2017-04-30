using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Math
{
    class LCM_HCF
    {
        //HCF is also known as greatest common divisor(GCD) or greatest common factor(gcf).
        /// <summary>
        /// 10,9,8,6
        /// 2|5,9,4,3
        /// 2|5,9,2,3
        /// 2|5,9,1,3
        /// 3|5,3,1,3
        /// 3|5,1,1,1
        /// 5|1,1,1,1
        /// =2*2*2*3*3*5
        /// 
        /// or 
        /// 10*9*8*6/gcd(10,9,8,6)
        /// </summary>
        /// <returns></returns>
        public int GetLCM(int a, int b)
        {
            return a * b / GetGCD(a, b);
        }
        public int GetLCM(List<int> args)
        {
            if (args.Count == 2)
            {
                return GetLCM(args[0], args[1]);
            }
            else
            {
                var arg0 = args[0];
                args.RemoveAt(0);
                return GetLCM(arg0, GetLCM(args));
            }
        }
        public int GetGCD(int a,int b)
        {
            int x = 0;
            while(b!=0)
            {
                x = b;
                b = a % b;
                a = x;
            }
            return a;
        }
        public int GetGCD(List<int> args)
        {
            if (args.Count == 2)
            {
                return GetGCD(args[0], args[1]);
            }
            else
            {
                var arg0 = args[0];
                args.RemoveAt(0);
                return GetGCD(arg0, GetLCM(args));
            }
        }
    }
}
