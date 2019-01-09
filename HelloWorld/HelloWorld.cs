using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            string fullName = "Drazen Lucic";
            string location = "Dubai, UAE";
            Console.WriteLine($"My name is {fullName}.");
            Console.WriteLine($"I am from {location}.");

            DateTime today = DateTime.Now;
            Console.WriteLine($"Today is {today:d}.");

            //The following code assure that the program will
            //work for any year, not just for 2019.

            //First, find current yeaar's Christmas
            DateTime nextChristmas = new DateTime(today.Year, 12, 25);
            
            //If the current date is greater than
            //this year's Christmas, add one year (i.e. take next year's Christmas).
            if (today > nextChristmas)
            {
                nextChristmas = nextChristmas.AddYears(1);
            }

            Console.WriteLine($"Next Christmas is on {nextChristmas:d}.");

            TimeSpan daysUntilChristmas = nextChristmas - today;
            Console.WriteLine($"Days unitl next Christmas: {daysUntilChristmas.Days}.");

            Console.Write("\nPress any key to end the program... ");
            Console.ReadLine();
        }
    }
}
