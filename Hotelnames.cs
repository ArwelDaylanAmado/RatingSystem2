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
                    
                    Rating.rating();

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
            foreach (var place in hotel)
            {
                Console.WriteLine(place);
            }
        }
    }
}
