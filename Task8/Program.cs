using System;

namespace Task8
{
    class Program
    {
        /*This is a program that takes in first two integers and add them together.
         * Then it takes two floats and add them together.
         * After that it asks for four numbers, where two is real and two is imaginary and add them together sepretly.*/

        static void Main(string[] args)
        {

            //Declare and initialize five integers, three float, two string variabl
            int firstInt = 0;
            int secondInt = 0;
            int firstIntImaginary = 0;
            int secondIntImaginary = 0;
            int methodResualtInt = 0;
            
            float firstFloat = 0.0F;
            float secondFloat = 0.0F;
            float methodResualtFloat = 0.0F;

            string firstname = "";
            string Lastname = "";

            //Integer
            while (methodResualtInt == 0)
            {
                try
                {
                    //Ask for user input values and convert and assig it too the first integer varible
                    Console.Write("Enter an integer and press Enter key: ");
                    firstInt = int.Parse(Console.ReadLine());

                    //Ask for user input values and convert and assig it too the second integer varible
                    Console.Write("Enter an integer and press Enter key: ");
                    secondInt = int.Parse(Console.ReadLine());

                    //Call the method with integer and assign value
                    methodResualtInt = calculateMethod(firstInt, secondInt);
                }
                catch
                {
                    //Display errormessage to the user
                    Console.WriteLine("\nDu måste ange en hel siffra \n");
                }

            }

            //Float
            while (methodResualtFloat == 0.0F)
            {
                try
                {
                    //Ask for user input values and convert and assig it too the first float varible
                    Console.Write("Enter an float and press Enter key: ");
                    firstFloat = float.Parse(Console.ReadLine());

                    //Ask for user input values and convert and assig it too the second float varible
                    Console.Write("Enter an float and press Enter key: ");
                    secondFloat = float.Parse(Console.ReadLine());

                    //Call the method with float and assign value
                    methodResualtFloat = calculateMethod(firstFloat, secondFloat);
                }
                catch
                {
                    //Display errormessage to the user
                    Console.WriteLine("\n Du måste ange en siffra med \",\" \n");
                }
            }

            //String
                //Ask for user input values and assig it too the string varible Last name
                Console.Write("Enter the last name and press Enter key: ");
                Lastname = Console.ReadLine();

                //Ask for user input values and convert and assig it too the string varible first name
                Console.Write("Enter an first name and press Enter key: ");
                firstname = Console.ReadLine();

                //Call the method with string
                calculateMethod(Lastname, firstname);

            //Complex
                //Clear the method resualt
                methodResualtInt = 0;

                while (methodResualtInt == 0)
                {
                    try
                    {

                        //Ask for user input values and convert and assig it too the first integer varible
                        Console.Write("Enter the real part of the first complex number and press Enter key: ");
                        firstInt = int.Parse(Console.ReadLine());

                        //Ask for user input values and convert and assig it too the first imaginary integer varible
                        Console.Write("Enter the imaginaty part of the first complex number and press Enter key: ");
                        firstIntImaginary = int.Parse(Console.ReadLine());

                        //Ask for user input values and convert and assig it too the second integer varible
                        Console.Write("Enter the real part of the second complex number and press Enter key: ");
                        secondInt = int.Parse(Console.ReadLine());

                        //Ask for user input values and convert and assig it too the second imaginary integer varible
                        Console.Write("Enter the imaginaty of the second complex number and press Enter key: ");
                        secondIntImaginary = int.Parse(Console.ReadLine());

                        //Call the method with integer and assign value
                        methodResualtInt = calculateMethod(firstInt, secondInt, firstIntImaginary, secondIntImaginary);

                    }
                    catch
                    {
                        //Display errormessage to the user
                        Console.WriteLine("\nDu måste ange en hel siffra \n");
                    }

                }
        }

        private static int calculateMethod(int firstInt, int secondInt)
        {
            //Declare and initialize a integer and calculate the value
            int sum = firstInt + secondInt;

            //Display resualt to the user
            Console.WriteLine("The sum of the two integer is {0}\n", sum);

            return sum;
        }
        private static float calculateMethod(float firstFloat, float secondFloat)
        {
            //Declare and initialize a float and calculate the value
            float sum = firstFloat + secondFloat;

            //Display resualt to the user
            Console.WriteLine("The sum of the two floiat numbers is {0}\n", sum);

            return sum;
        }
        private static string calculateMethod(string Lastname, string firstname)
        {
            //Declare and initialize a string and combine first and last name
            string name = firstname + " " + Lastname;

            //Display resualt to the user
            Console.WriteLine("Your name is {0}\n", name);

            return name;
        }
        private static int calculateMethod(int firstInt, int secondInt, int firstIntImaginary, int secondIntImaginary)
        {
            //Declare and initialize a integer and calculate the value
            int sum = firstInt + secondInt;

            //Declare and initialize a second integer and calculate the value
            int sumImaginaty = firstIntImaginary + secondIntImaginary;

            //Display resualt to the user
            Console.WriteLine("The sum of the two complex numbers is {0} + {1}i\n", sum, sumImaginaty);

            return sum;
        }

    }
}
