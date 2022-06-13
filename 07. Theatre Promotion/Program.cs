using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ticketPrice = 0;

            if (age>122 || age < 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                switch (dayOfWeek)
                {
                    case "Weekday":
                        if (0 <= age && age <= 18)
                        {
                            ticketPrice = 12;
                        }
                        else if (18 < age && age <= 64)
                        {
                            ticketPrice = 18;

                        }
                        else if (64 < age && age <= 122)
                        {
                            ticketPrice = 12;

                        }
                        break;
                    case "Weekend":
                        if (0 <= age && age <= 18)
                        {
                            ticketPrice = 15;

                        }
                        else if (18 < age && age <= 64)
                        {
                            ticketPrice = 20;

                        }
                        else if (64 < age && age <= 122)
                        {
                            ticketPrice = 15;

                        }
                        break;
                    case "Holiday":
                        if (0 <= age && age <= 18)
                        {
                            ticketPrice = 5;

                        }
                        else if (18 < age && age <= 64)
                        {
                            ticketPrice = 12;

                        }
                        else if (64 < age && age <= 122)
                        {
                            ticketPrice = 10;

                        }
                        break;
                    default:
                        break;
                }
                        Console.WriteLine($"{ticketPrice}$");
            }
        }
    }
}
