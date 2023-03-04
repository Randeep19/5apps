using System;

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

        public void Run()
        {
            Console.WriteLine("Enter the Weight (in Kilograms): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height (in Meters): ");
            double height = Convert.ToDouble(Console.ReadLine());

            //calculate bmi
            double BMI_outcome = weight / (height * height);
            Console.WriteLine(" The calculated BMI is " + BMI_outcome);
          
            if (bmi > 18.5 && bmi < 24.9)
                Console.Write("BMI is Normal.");
            else if (bmi <18.50 )
                Console.Write("User is Underweight");
            else if (bmi > 25 && bmi < 29.9)
                Console.Write("User is Overweight");
            else if (bmi > 30 && bmi < 34.9)
                Console.Write("Obese Class 1");
            else if (bmi > 35 && bmi < 39.9)
                Console.Write("obese Class 2");
            else if (bmi >= 40)
                Console.Write("Obese Class 3");
            else
                Console.Write("Obese!");

            Console.ReadKey();
        }
    }
}
