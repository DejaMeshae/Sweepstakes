using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    public class SweepstakesClass
    {
        //member variable
        string name;
        private int winner;
        Dictionary<int, Contestant> individuals = new Dictionary<int, Contestant>();

        //constructor
        //private string name;
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }

        //    set
        //    {
        //        name = value;
        //    }
        //}

        public SweepstakesClass(string sweepstakesname) //Random rnd**might not need this
        {
            this.name = sweepstakesname;
            //this.rnd = rnd;
            //Random rnd = new Random();
        }

        public void RegisterContestant(Contestant contestant)//Add to dictionary test
        {
            individuals.Add(1, contestant);
        }

        public string PickWinner()
        {
            //random method 
           // winner = rnd.Next(50, 100);
            throw new System.NotImplementedException();
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            //pull value of the random method key 
            //cww here is the winner here have the method in the userinterface and call it here 
            //
            Console.WriteLine("Here is the contestant information: ", contestant);
        }
    }
}


        //**dictionary tests delete**
        //foreach (KeyValuePair<int, Contestant> pair in individuals)
        //{
        //    Console.WriteLine(pair.Key + " - " + pair.Value);
        //}

        //string findPerson = individuals[2];
        //Console.WriteLine("The last name of this person is {0}", findPerson);

        //if (values.TryGetValue("1", out string info))
        //{
        //    Console.WriteLine(info);
        //}