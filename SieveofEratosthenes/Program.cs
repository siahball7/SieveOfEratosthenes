using System;
using System.Collections.Generic;
using System.Linq;

namespace SieveofEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer greater than 2: ");
            string userInput = Console.ReadLine();
            SieveOfEratosthenesTask j = new SieveOfEratosthenesTask();
            int userNum = j.IntegerCheck(userInput);
            List<int> result = j.SieveOfEratosthenesMath(userNum);
            Console.WriteLine("The primes between 0 and " + userNum + " are: ");
            result.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }

    class SieveOfEratosthenesTask
    {
        public List<int> SieveOfEratosthenesMath(int n)
        {
            List<int> numCheck = new List<int>();
            for (int i = 2; i < n; i++)
            {
                int numOfDivisors = 0;
                for(int j=2; j<i; j++)
                {
                    if (i % j == 0)
                    {
                        numOfDivisors++;
                    }
                }
                if(numOfDivisors == 0)
                {
                    numCheck.Add(i);
                }
            }
            return numCheck;
        }

        public int IntegerCheck(string s)
        {
            int num;
            while (int.TryParse(s, out num) == false)
            {
                Console.WriteLine("I'm sorry, the number you input is invalid. Please enter an integer greater than 2: ");
                s = Console.ReadLine();
            }
            int n = Convert.ToInt32(s);
            return n;
        }
    }
}
