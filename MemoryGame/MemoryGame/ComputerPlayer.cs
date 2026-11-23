using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal class ComputerPlayer : MainActor
    { 
        private readonly string _name = "computer";
      
        public override int liftCards()
        {
            Random random = new Random(); 
            int mis = random.Next(0, 16);
            //while (listCards[mis] == null)
            //{
            //    mis = random.Next(0, 16);
            //}

            return mis;
        }
    }
}
