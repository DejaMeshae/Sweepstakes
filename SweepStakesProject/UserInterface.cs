using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    public class UserInterface
    {
        //member variable
        string name;


        //constructor



        //member method
        //****Might not need this***
        //public void GetFirstName()
        //{
        //    Console.WriteLine("Please Enter your first name:");
        //    string FirstName = Console.ReadLine();
        //}

        public void GetEmailAddress() //gets contestant name and email address
        {
            Console.WriteLine("To enter please type your email address and press enter: ");
            string EmailAddress = Console.ReadLine();
        }

        public void GetName()
        {
            Console.WriteLine("Please type in your first name: ");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please type in your last name: ");
            string LastName = Console.ReadLine();

            string name = FirstName + " " + LastName; //joining first name and last name with a spacein between
            Console.WriteLine("Thank you for entering the sweepstakes " + name + ", good luck!"); //Test delete later
        }


    }
}
