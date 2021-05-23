using System;

namespace Task1
{
    class Program
    {
        /*This is a program that shows calculated tabel for number to square to cube.
         * The user gets to dictce how long it wants the tabel to go. */

        static void Main(string[] args)
        {
            //Declare and initialize two integers variables
            int squareValue = 1;
            int cubeValue = 1;

            //Display the headers to user
            Console.WriteLine("Number \tSquare \tCube");

            //Loop thougt the 10 rows
            for (int numberValue = 1; numberValue < 11; numberValue++)
            {
                //Calculate and assaigne squareValue
                squareValue = numberValue* numberValue;

                //Calculate and assaigne squareValue
                cubeValue = squareValue * numberValue;

                //Display the result to user
                Console.WriteLine("{0} \t{1} \t{2}", numberValue, squareValue, cubeValue);

            }

        }
    }
}
