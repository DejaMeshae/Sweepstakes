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
        private int winner;
        Dictionary<int, Contestant> individuals = new Dictionary<int, Contestant>();



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


        public SweepstakesClass()
        {

        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public SweepstakesClass(string name) //Random rnd**might not need this
        {
            this.name = name;
            //this.rnd = rnd;
            //Random rnd = new Random();
        }

        public void RegisterContestant(Contestant contestant)//Dictionary test
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
            Console.WriteLine("Here is the contestant information: ");       
            throw new System.NotImplementedException();
        }
    }
}
