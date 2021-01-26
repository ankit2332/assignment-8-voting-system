using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_8_voting_system
{
    class vote
    {
        private string votername;
        private string partyname;
        private DateTime votetime;
        private static int total;

        public vote(string votername, string partyname)
        {
            this.votername = votername;
            this.partyname = partyname;
            votetime = DateTime.Now;
        }
        public string getpartyname()
        {
            return partyname;
        }
        public int gettotalvotes()
        {
            return total;
        }

        public DateTime gettimevoted() => votetime;

    }
}
