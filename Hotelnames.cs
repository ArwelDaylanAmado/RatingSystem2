using System;
using System.Collections.Generic;
using System.Text;

namespace RatingSystem
{
    static class hotelnames
    {
        public static void Hotelrating()
        {
            List<string> hotel = new List<string>
            {
                "San Pedro Hotel",
                "Manila Hotel",
                "Santa Rosa Hotel"
            };

            while (true)
            {
                Console.WriteLine("Hotel names: ");
                DisplayListContents(hotel);

                Console.Write("\nEnter the hotel that you want to rate: ");
                var searchhotel = Console.ReadLine();

                var result = hotel.Find(x => x == searchhotel);
                
                if (result != null)
                {
                    Console.WriteLine("Proceed with rating for hotel: " + result);
                    
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
                    Console.WriteLine("rating total:" + Total);

                    Console.WriteLine("Thank you for Rating this Hotel!!");

                    break;

                }
                else
                {
                    Console.WriteLine("Name not found");
                    Console.WriteLine("Please try again");
                }
            }
        }

        static void DisplayListContents(List<string> hotel)
        {
            foreach (var book in hotel)
            {
                Console.WriteLine(book);
            }
        }
    }
}
