using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder(Console.ReadLine().Trim());
            PrintPermute(str, 0, str.Length);
        }

        private static void PrintPermute(StringBuilder str, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = left; i < right; i++)
                {
                    Swap(str, i, left);
                    PrintPermute(str, left + 1, right);
                    Swap(str, left, i);
                }
            }
        }

        private static void Swap(StringBuilder str, int i, int left)
        {
            char c = str[i];
            str[i] = str[left];
            str[left] = c;
        }
    }
}
