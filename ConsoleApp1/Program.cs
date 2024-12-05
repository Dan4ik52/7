using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите номер задачи: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {

                case 1:
                    Console.Write("Условие задачи: Все двухзначные числа, в записи которых все цифры разные.\n Решение:\n");
                    for (int i = 10; i <= 99; i++)

                    {
                        if (i / 10 != i % 10)

                            Console.WriteLine(i);
                    }
                    break;

                case 2:

                    for (int i = 5; i > 0; i--)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(j + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                case 3:

                    Console.Write("Условие: Найти натуральное число m интервала от a до b, у которого количество делителей максимально. Если таких чисел несколько, то должно быть найдено минимальное из них\nВведите начало диапазона: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Введите конец диапазона: ");
                    int b = int.Parse(Console.ReadLine());

                    int maxDivisors = 0;
                    int numberWithMaxDivisors = 0;

                    for (int i = a; i <= b; i++)
                    {
                        int count = 0;


                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                count++;
                            }
                        }

                       
                        if (count > maxDivisors || (count == maxDivisors && i < numberWithMaxDivisors))
                        {
                            maxDivisors = count;
                            numberWithMaxDivisors = i;
                        }
                    }

                    Console.WriteLine($"Число с максимальным количеством делителей: {numberWithMaxDivisors}");
                    Console.WriteLine($"Количество делителей: {maxDivisors} ");
                    break;
                default: Console.WriteLine("Введите правильный номер задачи!"); break;
            }
                    Console.ReadKey();
        }
    }
}
