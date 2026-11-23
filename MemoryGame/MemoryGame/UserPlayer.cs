using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal class UserPlayer : MainActor
    {

        public override string? YourName { get; set; }
        public UserPlayer()
        {
            name();
        }
        public override void name()
        {
            Console.WriteLine("insert your name");
            this.YourName= Console.ReadLine();
        }
        public override int liftCards()
        {
            Console.WriteLine("insert mis card");
            int mis=int.Parse( Console.ReadLine());
            //while (listCards[mis] == null)
            //{
            //    Console.WriteLine("The card is empty. Press another card.");
            //    mis = int.Parse(Console.ReadLine());
            //}
            return mis;
        }
    }
}
