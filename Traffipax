using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traffipax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seb = new int[100];
            int i = 0;
            int s = 0;
            do
            {
                Console.Write("Írjon be egy sebességet: ");
                s = Convert.ToInt32(Console.ReadLine());
                seb[i] = s;
                i++;
            } while (s != 0 && i < seb.Length);

            int dbkkmet = 0;
            int dbkkf = 0;

            for (i = 0; seb[i] != 0; i++)
            {
                if (seb[i] > 90)
                {
                    dbkkmet++;
                }
                if (seb[i] < -90)
                {
                    dbkkf++;
                }
            }

            Console.WriteLine($"Kecskemét felé {dbkkmet}, Félegyháza felé {dbkkf} gyorshajtó volt.");

            int osszegkmet = 0;
            int osszegkf = 0;
            int dbkmet = 0;
            int dbkf = 0;

            for (i = 0; seb[i] != 0 ; i++)
            {
                if (seb[i] > 0)
                {
                    osszegkmet += seb[i];
                    dbkmet++;
                }
                else
                {
                    osszegkf += seb[i];
                    dbkf++;
                }
            }

            double atlagkmet = (double) osszegkmet / dbkmet;
            double atlagkf = (double) -osszegkf / dbkf;

            Console.WriteLine($"Kecskemét felé {atlagkmet:0.00}, Félegyháza felé {atlagkf:0.00} volt az átlagsebesség.");

            int maxkmet = 0;
            int maxikmet = 0;
            int maxkf = 0;
            int maxikf = 0;

            for (i = 0; seb[i] != 0; i++)
            {
                if (seb[i] > maxkmet)
                {
                    maxkmet = seb[i];
                    maxikmet = i;
                }

                if (seb[i] < maxkf)
                {
                    maxkf = seb[i];
                    maxikf = i;
                }
            }

            Console.WriteLine($"Kecskemét felé a leggyorsabban a {maxikmet + 1}-ik autó ment, {maxkmet} km/h-val");
            Console.WriteLine($"Kiksunfélegyháza felé a leggyorsabban a {maxikf + 1}-ik autó ment, {maxkf} km/h-val");




        }
    }
}
