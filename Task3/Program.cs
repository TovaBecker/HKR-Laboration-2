using System;

namespace Task3
{
    class Program
    {
        /*This is a program that displays a square of stars too the user.
         * The user gets to chose a size between 2-16. */

        static void Main(string[] args)
        {
            //Declare and initialize a integer
            int inputValue = 0;

            //Ask for user input value
            Console.Write("Please enter the size of a square: ");

            //Catch worng inputvalue type
            try
            {
                //Assing value to intger varibl
                inputValue = int.Parse(Console.ReadLine());

                //Make space between input and output
                Console.WriteLine(" ");

                if (inputValue < 2)
                {
                    //Assign inputvalue to two
                    inputValue = 2;

                    //Create the square and display it to the user
                    buildSquare(inputValue);
                }
                else if (16 < inputValue)
                {
                    //Assign inputvalue to two
                    inputValue = 16;

                    //Create the square and display it to the user
                    buildSquare(inputValue);
                }
                else
                {
                    //Create the square and display it to the user
                    buildSquare(inputValue);
                }
            }
            catch
            {
                //Display errormessage to the user
                Console.WriteLine("Error - not a valid input\n");
            }

        }

        private static void buildSquare(int inputValue)
        {
            //Declare and initialize a string
            string square = "";

            //Create the line and assign it to square
            for (int j = 0; j < inputValue; j++)
            {
                square += "*";
            }

            //Create the square whit the lines and display it to the user
            for (int i = 0; i < inputValue; i++)
            {
                Console.WriteLine("\t{0}", square);
            }
        }
    }
}
