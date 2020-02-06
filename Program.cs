/* 
 Programmer: Shane Scallon
 Date: 2/6/2020
 Description: This console application uses a value returning method to take the users
 input and return the input back to the user.
 */
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user to enter their name
            Console.WriteLine("Please enter your first and last name...");

            try
            {
                //variable gathers data from users input
                string input = Console.ReadLine();

                //calls the method Full_Name
                Full_Name(input);
               

            }//end of try
            catch
            {
                Console.WriteLine("Please restart application and enter only first and last name");
                Console.WriteLine("Press any button to exit");
                Console.ReadKey(true);
            }//end of catch
        }
        //This return method is used to return the data input to the user
        private static string Full_Name(string Get_Name)
        {
            Console.WriteLine("Hello " + Get_Name + "!");

            Console.WriteLine("Press any button to exit the program...");

            return Get_Name;

            
        }
    }
}
