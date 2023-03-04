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

        public void Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
