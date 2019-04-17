using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant contestant = new Contestant();
            SweepstakesClass sweepstakesClass = new SweepstakesClass(""); //talked to other guy seems like im going to ask in the manager class what would you like the name of the sweepstakes to be and this will be the sweepstakes name
            UserInterface.GetFirstName(); //Testing this and above are running in the constructor
            UserInterface.GetLastName();//Testing
            UserInterface.GetEmailAddress(); //Testing
            //UserInterface.Thanks(firstName, lastName);//Testing
            sweepstakesClass.RegisterContestant(contestant);//Testing 
            sweepstakesClass.PrintContestantInfo(contestant);
            Console.ReadLine();//test delete later



        }
    }
}
