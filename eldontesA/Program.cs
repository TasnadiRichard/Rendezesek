using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eldontesA
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Eldöntés "A"
            // Eldöntés az összes elem vizsgálatával
            int n;

            n = (int)inputValue();
            int[] tomb = new int[n];
            int i;

            for (i = 0; i <= n - 1; i++)
            {
                tomb[i] = (int)inputValue();
            }
            int szam;

            szam = (int)inputValue();
            int k;

            k = 0;
            for (i = 0; i <= n - 1; i++)
            {
                if (tomb[i] == szam)
                {
                    k = k + 1;
                }
            }
            if (k == 0)
            {
                Console.WriteLine("Nincs benne");
            }
            else
            {
                Console.WriteLine("Benne van");
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

