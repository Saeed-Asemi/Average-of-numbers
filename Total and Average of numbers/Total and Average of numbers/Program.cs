using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_and_Average_of_numbers
{
    class Program
    {
        static int total(int[] a)
        {
            int sum = 0;
            int i = 0;
            for (i = 0; i < a.Length; i++)
            {
                Console.Write($"Please enter number {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
                sum += a[i];
            }
            Console.WriteLine($"Sum of array is : {sum}");
            return sum;
        }
        static int average(int[] a, int b)
        {
            int m;
            m = b / a.Length;
            Console.WriteLine($"The average of {a.Length} numbers is : {m}");
            return m;
        }
        static void Smaller(int[] a, int b)
        {
            Console.Write($"These numbers Smaller than average : ");
            for (int i =0;i<a.Length;i++)
            {
                if(a[i]<b)
                {
                    Console.Write($"{a[i]}   ");
                }
            }

        }
        static void Main(string[] args)
        {
            int m;
            int sum=0;
            int av = 0;
            Console.Write("Please enter total : ");
            m =int.Parse( Console.ReadLine());
            int[] n = new int[m];
            sum=total(n);
            av=average(n, sum);
            Smaller(n, av);
            Console.ReadKey();
        }
    }
}
