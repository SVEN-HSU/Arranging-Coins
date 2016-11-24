//https://leetcode.com/problems/arranging-coins/
//Accepted
//low performance :<
/*
 * discuss:
 * https://discuss.leetcode.com/topic/65575/java-o-1-solution-math-problem/8
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arranging_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ArrangeCoins(3);
            Console.Read();

        }

        public int ArrangeCoins(int n)
        {
            double floor = Math.Floor(Math.Sqrt(n));
            Console.WriteLine("n_sqrt(" + n + ")=" + floor);
            double celling = floor * 2 + 1;
            double result = 0;

            while (true)
            {
                Console.WriteLine("floor=" + floor);
                Console.WriteLine("celling=" + celling);

                if (n - ((floor * floor + floor) / 2) > (floor + 1))
                {
                    floor++;
                }
                else if (n - ((floor * floor + floor) / 2) == (floor + 1))
                {
                    result = floor + 1;
                    Console.WriteLine("result(f)=" + result);
                    break;                
                }
                else
                {
                    result = floor;
                    Console.WriteLine("result(f)=" + result);
                    break;
                }

                if (((celling * celling + celling) / 2) - n > 0)
                {
                    celling--;
                }
                else
                {
                    result = celling;
                    Console.WriteLine("result(c)=" + celling);
                    break;
                }
            }

            result = Math.Floor(result);
            Console.WriteLine("Math.Abs(result)=" + result);

            return Convert.ToInt32(result);
        }
    }
}
