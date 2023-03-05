using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class will convert distncew unit. It allow users to 
    /// select the from to unit and then will calculate distance from the distance.
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
       const int MILES_TO_FEET = 5280;
       public double fromDistance;
       public double toDistance;
        
       public string fromUnit;
       public string toUnit;
       public string toUnit1;
        
        public DistanceConverter()
        {

        }
        
        public void Run()
        {
            fromUnit = "feet";
            toUnit = "miles";
            toUnit1 = "meters";

            Input();
            ConvertDistance();
            print();
            
            Input2();
            ConvertDistance2();
            printoutput2();

            FEET_TO_METERS();
            MILES_TO_METERS();  
        }

        //CONVERTING FEET TO MILES;
        public void Input()
        {
            //Input the number the number of Feet;
            Console.Write(" ~ Please enter the number of " + fromUnit + ": ");
            fromDistance = Convert.ToDouble(Console.ReadLine());
        }
        public void ConvertDistance()
        {
            //convert the distance from feet to miles;
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
            //print the output;
            // Console.WriteLine(feet + " feet is " + miles.ToString("0.00") + " miles ");
            Console.Write(" " + fromDistance + "  " + fromUnit + " is " + toDistance.ToString("0.00") + " " + toUnit + ".");
            Console.WriteLine();
        }




        //CONVERTING THE MILES TO FEET;
        public void Input2()
        {
            //Input the number the number of Miles;
            Console.Write(" ~ Please enter the number of " + toUnit + ": ");
            fromDistance = Convert.ToDouble(Console.ReadLine());
        }
        public void ConvertDistance2()
        {
            //convert the distance from miles to Feet;
            if (fromUnit == "miles" && toUnit == "feet")
            {
                toDistance = fromDistance / MILES_TO_FEET;
            }
            else if (fromUnit == "feet" && toUnit == "miles")
            {
                toDistance = fromDistance * MILES_TO_FEET;
            }
        }
        public void printoutput2()
        {
            //print the output;
            // Console.Write(feet + " feet is " + miles.ToString("0.00") + " miles ");
            Console.WriteLine(" " + fromDistance + "  " + toUnit + " is " + toDistance + " " + fromUnit + ".");
            Console.WriteLine();
        }


        //CONVERTING FEET TO METERS;
        public void FEET_TO_METERS()
        {
            double feet, meters;

            Console.Write(" ~ Please enter the number of feet: ");
            feet = Convert.ToDouble(Console.ReadLine());

            //convert the distance from feet to meters;
            meters = feet * 0.3048;

            // Console.Write(feet + " feet is " + miles.ToString("0.00") + " miles ");
            Console.WriteLine(" " + fromDistance + "  " + fromUnit + " is " + meters + " " + toUnit1 + ".");
            Console.WriteLine();
        }
        

        //CONVERTING MILES TO METERS;
        public void MILES_TO_METERS()
        {
            double miles, meters;

            Console.Write(" ~ Please enter the number of miles: ");
            miles = Convert.ToDouble(Console.ReadLine());

            //convert the distance from miles to meters;
            meters = miles * 1609.34;

            // Console.Write(feet + " feet is " + miles.ToString("0.00") + " miles ");
            Console.WriteLine(" " + fromDistance + "  " + toUnit + " is " + meters + " " + toUnit1 + ".");
            Console.WriteLine();
        }

    }
}
