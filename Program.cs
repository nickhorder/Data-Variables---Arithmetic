using System;

namespace Data_Variables___Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            /*TASK1 - Increment/Decrement
			*/
            Console.WriteLine("// This is Task1 //\n");
            // declare steps variable
            int steps = 0;
            // Two steps forward 
            steps = steps + 2;
            // One step back 
            steps = steps - 1;
            // Print result to the console
            Console.WriteLine("The total number of steps is now: "
            + steps + "\n");
            //
            /*TASK2 - Multiplication, Addition with Doubles
			*/
            Console.WriteLine("// This is Task2 //\n");
            // Your Age
            int userAge = 35;
            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;
            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;
            // Time to Jupiter
            double journeyToJupiter = 6.142466;
            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;
            // New Age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;
            Console.WriteLine("my earth age, before settting off for Jupiter: "
            + userAge);
            Console.WriteLine("Length of time to get to Jupiter: "
            + journeyToJupiter);
            Console.WriteLine("my earth age, when arriving on Jupiter: "
            + newEarthAge);
            Console.WriteLine("my age in Jupiter years, after arriving on Jupiter: "
            + newJupiterAge + "\n");
            //
            /*TASK3 - Modulo
			The "Modulo" shows you the remaining values that do not cleanly
			divide into another number - i.e 18/4
			*/
            Console.WriteLine("// This is Task3 //\n");
            // Number of students
            int students = 18;
            // Number of students in a group
            int groupSize = 4;
            // Does groupSize go evenly into students?        
            Console.WriteLine("Remainder from Total Students divided by Total Groups: "
            + students % groupSize + "\n");

            /*TASK4 - Raise by Power, Find Largest
			
			Math.Floor - Round down to nearest full Integer
			Math.Ceiling - Round up to the nearest full integer
			Math.Sqrt - square root
			Math.Abs - convert to absolute (i.e a negative value becomes positive)
			Math.Min - show the lowest number from a selection
			Math.Max - show the largest number in a selection
			
			*/
            Console.WriteLine("// This is Task4 //\n");
            // Log calculations to console
            // Starting variables 
            int numberOne = 12932;
            int numberTwo = -2828472;
            // Use built-in methods and save to variable 
            double numberOneSqrt =
            Math.Floor(Math.Sqrt(numberOne));
            // Use built-in methods and save to variable 
            double numberTwoSqrt =
            Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));
            // Print the lowest number
            Console.WriteLine("Displaying only the lowest number: " 
            + Math.Min(numberOneSqrt, numberTwoSqrt));
            double numberThree = 6.5;
            double numberFour = 4;
            // Raise numberThree to the numberFour power
            Console.WriteLine("numberThree raised to the power of numberFour: "
            + Math.Pow(numberThree, numberFour));
            // Round numberOne up
            Console.WriteLine("numberOne rounded up: "
            + Math.Ceiling(numberThree));
            // Find the larger number between numberOne and numberTwo
            Console.WriteLine("The larger of numberOne / numberTwo: "
            + Math.Max(numberThree, numberFour));
            Console.WriteLine("\n" + "// End of Tasks //");
        }
    }
}
