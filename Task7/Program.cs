using System;

namespace Task7
{
    class Program
    {
        // This is a program thant takes in numbers from the user and when the user press zero shows what input numbers that has been the lowest.

        static void Main(string[] args)
        {
            //Declare and initialize two integer variables
            int number = 0;
            int min = int.MaxValue;

            //Display infomation to the user
            Console.WriteLine("\nHär är ett konsollprogram som läser in nummer och visar vilket som är minst." +
                "              \nSkriv ett nummer och tryck sedan på Enter." +
                "              \nFör att avsluta tryck på 0 och sedan på Enter\n");

            while (number == 0)
            {
                try
                {
                    //Ask for user input values and assig it too a int varible
                    Console.Write("Skriv ett nummer: ");
                    number = int.Parse(Console.ReadLine());

                    //Declare and assaign a integer variabl
                    min = number;
                }
                catch
                {
                    //Display error messige for the user
                    Console.WriteLine("The input needs to be an integer \n");
                }
            }

            //Walk thought the list to find the minimum number
            while (number != 0)
            {
                //Check that the user input is valid
                try
                {
                    if (number < min) min = number;

                    //Ask for user input values and assig it too a int varible
                    Console.Write("Skriv ett till nummer: ");
                    number = int.Parse(Console.ReadLine());

                }
                catch (FormatException e)
                {
                    //Display errormessage to the user
                    Console.WriteLine("\nDu måste ange siffror");
                }
            }
            //Display the minimum number to the user
            Console.WriteLine($"\nDet minsta nummret du skrivit är: {min}");

        }
    }
}
