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

                string input = Console.ReadLine();

                string inputValue = Full_Name(input);
               



            }//end of try
            catch
            {
                Console.WriteLine("Please restart application and enter only first and last name");
                Console.WriteLine("Press any button to exit");
                Console.ReadKey(true);
            }//end of catch
        }
        private static string Full_Name(string Get_Name)
        {
            Console.WriteLine("Hello " + Get_Name);

            return Get_Name;

            
        }
    }
}
