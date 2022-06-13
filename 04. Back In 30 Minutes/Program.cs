using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;
            if (minutes > 59)
            {
                hour++;
                minutes -= 60;
            }
            if (hour >= 24)
            {
                hour -= 24;
                
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");

            }




        }
    }
}
