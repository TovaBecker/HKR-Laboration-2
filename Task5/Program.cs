using System;

namespace Task5
{
    class Program
    {
        //This is a program that shows a conversion tabel for celsius to fahrenheit.

        static void Main(string[] args)
        {
            //Declare and initialize a double
            double fahrenheit = 0;

            //Display the headers to user
            Console.WriteLine("Celsius \tFahrenheit");

            for (int celsius = -30; celsius < 55; celsius += 5)
            {
                fahrenheit = (9 / 5) * celsius + 32;
                
                //Display the resualt to the user
                Console.WriteLine("{0} \t\t{1}", celsius, fahrenheit);
            }
        }
    }
}
