using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* FIRME METODI
             * static bool[] ConvertDpToBin(int[] dp) METODO 1
             * static int ConvertDpToIntero(int[] dp) METODO 2
             * static int ConvertBinToIntero(bool[] bn)  METODO 3
             * static int ConvertBinToDec(bool[] bn) METODO 4 
             */
            int[] dp = { 192, 168, 10, 1 };

            bool[] b = ConverDpToBin(dp);

            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(Convert.ToInt32(b[i]));
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        static bool[] ConverDpToBin(int[] dp)
        {
            bool[] b = new bool[32];
            int n, j;

            for (int i = 0; i < dp.Length; i++)
            {
                n = dp[i];
                j = 7;
                do
                {
                    if (n % 2 == 1)
                    {
                        b[j + i * 8] = true;
                    }

                    n = n / 2;
                    j--;

                } while (n > 0);
            }

            return b;
        }
    }
}
