using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = 0;
            int c = 0;
            int g = 0;
            int nbrOft = 0;
            int nbrOfc = 0;
            int nbrOfg = 0;
            int sum = 0;

            foreach (var l in Console.ReadLine())
            {
                switch (l)
                {
                    case 'T': t++; nbrOft++; break;
                    case 'C': c++; nbrOfc++; break;
                    case 'G': g++; nbrOfg++; break;
                    default:
                        break;
                }

                if (nbrOft >= 1 && nbrOfc >= 1 && nbrOfg >= 1)
                {
                    sum += 7;
                    nbrOft--;
                    nbrOfg--;
                    nbrOfc--;
                }
            }

            sum += (Convert.ToInt32(Math.Pow(t, 2)) + Convert.ToInt32(Math.Pow(c, 2)) + Convert.ToInt32(Math.Pow(g, 2)));

            Console.WriteLine(sum);
        }
    }
}
