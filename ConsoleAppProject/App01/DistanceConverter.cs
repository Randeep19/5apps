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
      

        double fromDistance;
        double toDistance;
        string fromUnit;
        string toUnit;



        public DistanceConverter()
        {

        }
        
        public void Run()
        {
            
            fromUnit = "feet";
            toUnit = "miles";

            Input();
            ConvertDistance();
            print();
        }
     
  

        public void MilesToFeet()
        {
            //step 1- input the miles
            Console.WriteLine("Please enter the number of miles: ");
            string input = Console.ReadLine();
            miles = Convert.ToDouble(input);
            Console.WriteLine("Miles Entered is: " + miles);

            //step 2- convert the number of miles into feet
            const int MILES_TO_FEET = 5280;
            feet = miles * MILES_TO_FEET;
            Console.WriteLine(miles + " miles are " + feet + " feet ");

            //output the screen
            Console.WriteLine(miles + " miles are " + feet + " feet ");
        }
        public void FeetToMiles()
        {
            //step 1- input the feet
            Console.WriteLine("Enter the number of Feet:");
            string input = Console.ReadLine();
            feet = Convert.ToDouble(input);
            Console.WriteLine("feet Entered is: " + feet);


            //step 2- convert the number of feet into miles
            const int MILES_TO_FEET = 5280;
            miles = feet / MILES_TO_FEET;
            Console.WriteLine(feet + " feet is " + miles + " miles ");

            //output the screen
            Console.WriteLine(feet + " feet is " + miles.ToString("0.00") + " miles ");
        }



        public void Input()
        {

            Console.WriteLine("Please enter the number of " + fromUnit);
            fromDistance = Convert.ToDouble(Console.ReadLine());
        }
        public void ConvertDistance()
        {
            if (fromUnit == "miles" && toUnit =="feet")
            {
                toDistance = fromDistance * MILES_TO_FEET;
            }
            else if(fromUnit == "feet" && toUnit == "miles")
            {
                toDistance = fromDistance / MILES_TO_FEET;
            }
        }
        public void print()
        {
            // Console.WriteLine(feet + " feet is " + miles.ToString("0.00") + " miles ");
            Console.WriteLine(fromDistance + "  " + fromUnit + " is " + toDistance + " " + toUnit);
        }
    }
}
