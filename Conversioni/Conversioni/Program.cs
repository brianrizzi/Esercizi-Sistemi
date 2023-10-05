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
            Console.WriteLine("\n=================================");

            Console.WriteLine(ConvertDpToIntero(dp));

            Console.WriteLine("=================================");

            Console.WriteLine(ConvertBinToIntero(b));

            Console.WriteLine("=================================");

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

        static int ConvertDpToIntero(int[] dp)
        {
            int dpToInt = 0, j = 3;

            for (int i = 0; i < dp.Length; i++)
            {
                dpToInt += dp[i] * (int)Math.Pow(256, j);

                j--;
            }

            return dpToInt;
        }

        static int ConvertBinToIntero(bool[] bn)
        {
            int binToInt = 0, j = 31;

            for (int i = 0; i < bn.Length; i++)
            {
                if (bn[i])
                {
                    binToInt += (int)Math.Pow(2, j);
                }
                j--;
            }

            return binToInt;
        }
    }
}
