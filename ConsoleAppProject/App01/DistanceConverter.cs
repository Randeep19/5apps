using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        const int MILES_TO_FEET = 5280;
        String input;
        int miles;
        int feet;

        public DistanceConverter()
        {

        }
        
        public void Run()
        {
            ConvertFeetToMiles();
            ConvertMilesToFeet();
        }
     
        public void ConvertFeetToMiles()
        {
            //step 1- input the feet
            Console.WriteLine("Enter the number of Feet:");
            string input = Console.ReadLine();
            int feet = Convert.ToInt32(input);
            Console.WriteLine("feet Entered is: ");

            //step 2- convert the number of feet into miles
            const int MILES_TO_FEET = 5280;
            int miles = feet / MILES_TO_FEET;
            Console.WriteLine(feet + " feet is " + miles + " miles ");

            //output the screen
            Console.WriteLine(feet + " feet is " + miles.ToString("0.00") + " miles ");
        }

        public void ConvertMilesToFeet()
        {
            //step 1- input the miles
            Console.WriteLine("Enter the number of miles:");
            string input = Console.ReadLine();
            int miles = Convert.ToInt32(input);

            //step 2- convert the nuber of miles into feet
            int feet = miles * 5280;
            Console.WriteLine(miles + " miles are " + feet + " feet ");

            //output the screen
            Console.WriteLine(miles + " miles are " + feet + " feet ");
        }
    }
}
