using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal class SignalCard:BasicCard
    {
        public char Signal { get; set; }

        public SignalCard()
        {
            
        }
        public SignalCard(char c)
        {
            this.Signal = c;
        }
        public override bool CheckMatch(BasicCard other)
        {
            //SignalCard other1 = other as SignalCard;
            //if (this.Equals(other) && this.Signal == other1.Signal)
            //    return true;
            //return false;
           return other is SignalCard otherCard && this.Signal == otherCard.Signal;

        }
        public override void DrawingCard(string? s = null)
        {
            base.DrawingCard(Signal.ToString());

        }
    }
}
