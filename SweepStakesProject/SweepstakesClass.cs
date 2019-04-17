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
        //create a dictionary of people 
        Contestant contestant = new Contestant();


        Dictionary<int, Contestant> individuals = new Dictionary<int, Contestant>();
        //individuals.Add(1, Contestant);
           

            //foreach (KeyValuePair<int, Contestant> pair in individuals)
            //{
            //    Console.WriteLine(pair.Key + " - " + pair.Value);
            //}

            //string findPerson = individuals[2];
            //Console.WriteLine("The last name of this person is {0}", findPerson);



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

        public SweepstakesClass(string name)
        {
            this.name = name;
        }

        //***********Methods To Create*********************
        public void RegisterContestant(Contestant contestant)//Dictionary test
        {
            //just assign the contestant info here
            throw new System.NotImplementedException();

        }

        public string PickWinner()
        {
            throw new System.NotImplementedException();
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            throw new System.NotImplementedException();
        }
    }
}
