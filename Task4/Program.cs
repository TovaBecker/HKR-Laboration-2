using System;

namespace Task4
{
    class Program
    {
        /*This is a program that shows what year the population vill exceed 10 billion.
         * If there is 6.5 bilion in population year 2021 and grows rate is 1,4%. */

        static void Main(string[] args)
        {
            //Declare and initialize a integer and tow double
            int year = 2021;
            double rate = 1.014;
            double population = 6500000000000;

            while (population < 10000000000000)
            {
                //calculate the populations grows
                population = population * rate;

                //increas the year
                year++;
            }

            //Display the year to the user
            Console.WriteLine("The population will exceed 10 billion in year {0}", year);
        }
    }
}
