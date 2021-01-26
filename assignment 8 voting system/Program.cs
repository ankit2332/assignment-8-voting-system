using System;

namespace assignment_8_voting_system
{
    class Program
    {
        static void Main(string[] args)
        {
            vote[] votes = new vote[10];
        }
        static void castvote(vote[] votes)
        {
            
            bool done = false;
            while (done == false)
            {
                Console.WriteLine("what is your name?");
                string votername = Console.ReadLine();
                Console.WriteLine("type 1 for party 1, type 2 for party 2 or type 3 for party 3");
                int partynumber = Console.Read();
                if( partynumber == 1)
                {
                    partyname = "party1"
                }
            }
            
        }
    }
}
