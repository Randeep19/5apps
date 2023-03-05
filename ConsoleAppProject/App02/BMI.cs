using System;
using System.Reflection;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {

        public void run()
        {
            Console.Write(" ~ Please enter the weight in kilograms: ");
            int kg;
            kg = Convert.ToInt32(Console.ReadLine());

            Console.Write(" ~ Please enter the height in meters: ");
            int m;
            m = Convert.ToInt32(Console.ReadLine());

           

            int BMI;
            BMI = kg / (m / 100) * (m / 100);

            if (BMI > 18.5 && BMI    < 24.9)
                Console.Write(" ~ BMI is Normal.");
            else if (BMI < 18.50)
                Console.Write(" ~ User is Underweight. ");
            else if (BMI > 25 && BMI < 29.9)
                Console.Write(" ~ User is Overweight. ");
            else if (BMI > 30 && BMI < 34.9)
                Console.Write(" ~ You are under obese Class 1. ");
            else if (BMI > 35 && BMI < 39.9)
                Console.Write(" ~ You are under obese Class 2. ");
            else if (BMI >= 40)
                Console.Write(" ~ You are under obese Class 3. ");
            else
                Console.Write(" ~ You are under Obese category.");

            Console.ReadLine();
        }
    }
}
