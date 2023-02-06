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
        public void feetToMiles()
        {
            //step 1- input the feet
            Console.WriteLine("Enter the number of Feet:");
            string input = Console.ReadLine();
            int feet = Convert.ToInt32(input);

            //step 2- convert the nuber of feet into miles
            int miles = feet / 5280;
            Console.WriteLine(feet + " feet is " + miles + " miles ");

            //output the screen
            Console.WriteLine(feet + " feet is " + miles.ToString("0.00") + " miles ");
        }

        public void milesToFeet()
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
