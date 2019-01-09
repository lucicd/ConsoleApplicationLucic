using System;

namespace GlazerCalc
{
    class GlazerCalc
    {
        private const double FEETS_PER_METER = 3.25;
        
        private static double getPositiveNumber(string prompt)
        {
            string inputStr;
            double inputNum = 0;
            bool inputCorrect = false;

            while (!inputCorrect)
            {
                try
                {
                    Console.Write(prompt);
                    inputStr = Console.ReadLine();
                    inputNum = double.Parse(inputStr);
                    if (inputNum > 0)
                    {
                        inputCorrect = true;
                    } else
                    {
                        Console.WriteLine("Please enter positive value.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter numeric value.");
                }
            }

            return inputNum;
        }

        static void Main(string[] args)
        {
            double width, height, woodLength, glassArea;

            width = getPositiveNumber("Enter width in meters: ");
            height = getPositiveNumber("Enter height in meters: ");
            
            woodLength = 2 * (width + height) * FEETS_PER_METER;
            glassArea = 2 * (width * height);

            Console.WriteLine($"The length of the wood is {woodLength} feet.");
            Console.WriteLine($"The area of the glass is {glassArea} square meters.");

            Console.Write("\nPress any key to end the program... ");
            Console.ReadLine();
        }
    }
}
