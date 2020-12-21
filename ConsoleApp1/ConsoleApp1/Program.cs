using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, s, a;
            int[] array1;

            Console.WriteLine("Введите элементы целочисленного одномерного массива!");
            array1 = new int[6];
            for (i = 0; i <= 5; i++)
            {
                Console.Write((i + 1) + "-й элемент: ");
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Введенный массив имеет следующий вид:");
            for (i = 0; i <= 5; i++)
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
                for (i = 0; i <= 5; i++)
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
