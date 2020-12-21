using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, s, a, n;
            int[] array1;

            Console.WriteLine("Введите размерность одномерного массива -");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите элементы целочисленного одномерного массива!");
            array1 = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write((i + 1) + "-й элемент: ");
                array1[i] = int.Parse(Console.ReadLine());
                if (array1[i] > 1000)
                {
                    array1[i] = 1000;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Введенный массив имеет следующий вид:");
            for (i = 0; i < n; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            while (true)
            {
                Console.Write("Введите число для поиска в массиве: ");
                s = int.Parse(Console.ReadLine());
                a = 0;
                for (i = 0; i < n; i++)
                {
                    if (array1[i] == s)
                    {
                        a = 1;
                        Console.WriteLine();
                        Console.WriteLine("Данное число находится в массиве под следующим номером: " + (i + 1));
                        Console.WriteLine();
                    }
                }
                if (a == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Данного числа нет во введенном массиве. Введите другое.");
                    Console.WriteLine();
                }
            }
        }
    }

}
