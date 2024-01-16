using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimumkivalasztasos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Adja meg a tömb számát");
            n = (int)inputValue();
            int[] t = new int[n];
            int i;

            for (i = 0; i <= n - 1; i++)
            {
                Console.Write("Kérem a " + (i + 1) + ". elemet: ");
                t[i] = (int)inputValue();
            }
            int minIndex;
            int j;
            int min;

            for (i = 0; i <= n - 2; i++)
            {
                minIndex = i;
                for (j = i + 1; j <= n - 1; j++)
                {
                    if (t[j] < t[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int tmp;

                    tmp = t[i];
                    t[i] = t[minIndex];
                    t[minIndex] = tmp;
                }
            }
            for (i = 0; i <= n - 1; i++)
            {
                Console.Write(t[i].ToString() + ", ");
            }
        }

        // .NET can only read single characters or entire lines from the
        // console. The following function safely reads a double value.
        private static double inputValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }
    }

}
