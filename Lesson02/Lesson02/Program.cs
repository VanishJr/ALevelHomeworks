using System;

namespace Lesson02
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Первое здание");
            int[] a = new int[10];
            for (int n = 0; n < a.Length; n++)
            {
                a[n] = new Random().Next(-100, 100);
            }
            var str = string.Join(" ", a);
            Console.WriteLine(str);
            Console.WriteLine("10 элементов в массиве");

            Console.WriteLine();

            Console.WriteLine("Второе задание");

            int[] A = new int[20];
            int[] B = new int[20];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = new Random().Next(-10000, 888);
                B[i] = A[i];

            }
            var str2 = string.Join(" ", A);
            Console.WriteLine(str2 + " " + "= это массив А");

            Array.Sort(B);
            Array.Reverse(B);
            Console.WriteLine();

            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i] + " ");
            }
            Console.Write(" " + "= это массив B");

            Console.ReadKey();
        }
    }
}