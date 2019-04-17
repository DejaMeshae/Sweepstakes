using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    public static class UserInterface 
    {
        //member variable

        
       //constructor


        //member method
        public static string GetFirstName()
        {
            Console.WriteLine("To enter the sweepstake please enter your first name and press enter:");
            string firstName = Console.ReadLine();
            return firstName;
        }

        public static string GetLastName()
        {
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();
            return lastName;
        }

        public static string GetEmailAddress() 
        {
            Console.WriteLine("Please enter your email address: ");
            string emailAddress = Console.ReadLine();

            return emailAddress;
        }

        public static void Thanks(string firstName, string lastName)
        {
            Console.WriteLine($"Thank you for entering the sweepstakes {firstName} {lastName}, good luck!"); //Test delete later
           
        }
    }
}
