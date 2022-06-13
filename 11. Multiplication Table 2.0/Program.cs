using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());
            //int multiplier = int.Parse(Console.ReadLine());
            //int sum = 0;
            //if (multiplier> 10)
            //{
            //    sum = num * multiplier;
            //    Console.WriteLine($"{num} X {multiplier} = {sum}");
            //}
            //else
            //{
            //    for (int i = multiplier; i <=10; i++)
            //    {
            //        sum = num * i;
            //        Console.WriteLine($"{num} X {i} = {sum}");
            //    }
            //}
            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{number} X {times} = {number * times }");
                times++;


            }
            while (times <= 10);
        }
    }
}
