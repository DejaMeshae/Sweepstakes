using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        //use Stack data structure

        public void InsertSweepstakes(SweepstakesClass sweepstakesclass)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(12);
            stack.Push(16);
            stack.Push(87);

            Console.WriteLine("Elements in stack: ");
            foreach (int number in stack)
            {
                Console.WriteLine(number);
            }

            int topOfStack = stack.Pop();

            stack.Push(3);

            Console.WriteLine("Elements in stack after Pop and Push(3): ");
            foreach (int number in stack)
            {
                Console.WriteLine(number);
            }
        }

    

        public SweepstakesClass GetSweepstakes()
            {
                throw new System.NotImplementedException();
            }

    }
}
