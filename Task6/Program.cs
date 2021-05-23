using System;

namespace Task6
{
    class Program
    {
        //This is a program where user can give a grade and see that grae's definition.

        static void Main(string[] args)
        {
            //Declare and initialize two string variabl
            string grade = "";
            string message = "";

            while (grade != "G")
            {
                //Ask for user input value and assig it too a string varible as capital letters
                Console.Write("Please enter your grade: ");
                grade = Console.ReadLine().ToUpper();

                //Check input value and assaing message value
                switch (grade)
                {
                    case "A":
                        message = "A Excellent – outstanding performance with only minor errors";
                        break;

                    case "B":
                        message = "B Very good – above the average standard but with some errors";
                        break;

                    case "C":
                        message = "C Good– generally sound work with a number of notable errors";
                        break;

                    case "D":
                        message = "D Satisfactory – fair but with significant shortcomings";
                        break;

                    case "E":
                        message = "E Sufficient – performance meets the minimum criteria";
                        break;

                    case "FX":
                        message = "Fx Fail – some more work required before the credit can be awarded";
                        break;

                    case "F":
                        message = "F Fail -considerable further work is required";
                        break;

                    case "G":
                        message = "Ending the program";
                        break;

                    default:
                        message = "Error - not a valid grade\n";
                        break;


                }

                //Display message to the user
                Console.WriteLine("\t{0}\n", message);

            }
        }
    }
}
