using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static bool q = false;
        static int[] vs = new int[100];
        static int count = 0;
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000000; i++)
            {
                if (SimpleDigits(i))
                {
                    q = false;
                    count = 0;
                    string str = Convert.ToString(i);
                    char[] strChar = str.ToCharArray();
                    Permute(strChar, 0, strChar.Length - 1);
                    if (q == true)
                    {
                        Console.WriteLine(i + "циклическое число");
                    }
                }
                else continue;
            }
            Console.ReadKey();

        }


        static bool SimpleDigits(int i)
        {
            bool check = false;
            int count = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
            }
            if (count == 2) check = true;
            return check;
        }

        static void Permute(char[] a, int i, int n)
        {
            int j;
            if (i == n)
            {
                for (int h = 0; h <= count; h++)
                {
                    if (SimpleDigits(vs[h])) q = true;
                    else break;
                }
            }
            else
            {
                char temp;
                for (j = i; j <= n; j++)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;

                    vs[count] = Convert.ToInt32(a[i]);
                    count++;

                    Permute(a, i + 1, n);
                }
            }
        }
    }
}   

