using System;

namespace Task2
{
    class Program
    {
        //This is a program that calculate the volume of a sphere.

        static void Main(string[] args)
        {
            //Declare and initialize a integer and a float variabl
            int radius = 0;
            float resultVolume = 0.0F;

            while (radius == 0)
            {
                try
                {
                    //Ask for user input value and assig it too integer varible
                    Console.Write("Please enter a integer: ");
                    radius = int.Parse(Console.ReadLine());
                }
                catch
                {
                    //Display error messige for the user
                    Console.WriteLine("The input needs to be an integer \n");
                }
            }
            //Make space between input and output
            Console.WriteLine(" ");

            for (int i = 1; i <= radius; i++)
            {
                //Call the method and get the resualt
                resultVolume = calculateVolume(i);

                //Display the result to user
                Console.WriteLine("Sphere’s volume with radius {0} is {1}", i, resultVolume);

            }
        }

        private static float calculateVolume(float radius)
        {
            //Declare and initialize a float variabl for this method
            float volume = 0.0F;

            //Calculate the Sphere’s volume
            volume = (float)(4.0 / 3 * Math.PI * radius * radius * radius);

            //returns volume 
            return volume;
        }
    }
}
