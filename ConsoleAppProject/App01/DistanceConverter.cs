﻿using System;

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
