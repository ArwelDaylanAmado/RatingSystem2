using System;
using System.Collections.Generic;
using System.Text;

namespace RatingSystem
{
    static class Rating
    {
        public static void rating()
        {
            double num1, num2, num3, num4, num5, Total;

                    Console.WriteLine("Rate the following from 1 as lowest and 5 as highest");
                    Console.WriteLine("1.Services");
                    Console.Write("Enter your Rate:");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("2.Foods");
                    Console.Write("Enter your Rate:");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("3.Cleanliness of the hotel");
                    Console.Write("Enter your Rate:");
                    num3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("4.Cleanliness of the room");
                    Console.Write("Enter your Rate:");
                    num4 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("5.Entertainment");
                    Console.Write("Enter your Rate:");
                    num5 = Convert.ToDouble(Console.ReadLine());

                    Total = (num1 + num2 + num3 + num4 + num5) / 5;
                    Console.WriteLine("Average rating total:" + Total);

                    Console.WriteLine("Thank you for Rating this Hotel!!");

        }
    }
}