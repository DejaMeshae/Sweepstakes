using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class Contestant : IUser
    {
        //member variable
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        private string emailAddress;
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                emailAddress = value;
            }
        }

        private int registrationNumber;
        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                registrationNumber = value;
            }
        }

        //constructor
        public Contestant()
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
        }
        //member method
        public void GetInfo()
        {
            Console.WriteLine("Please Enter your first name: ");
            Console.ReadLine();
            Console.WriteLine("Please Enter your last name: ");
            Console.ReadLine();
            Console.WriteLine("Please Enter your email address name: ");
            Console.ReadLine();
        }
    }
}
