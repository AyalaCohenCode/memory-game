using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    /// <summary>
    /// סמל
    /// </summary>
    internal class SymbolCard:BasicCard
    {
        public char Symbol { get; set; }
        public ConsoleColor Color { get; set; }
        public SymbolCard()
        {
            
        }
        public SymbolCard(char Symbol, ConsoleColor Color)
        {
            this.Symbol = Symbol;
            this.Color = Color;
        }
        public override bool CheckMatch(BasicCard other)
        {
            //SymbolCard other1 = other as SymbolCard;
            //if (this.Equals(other) && this.Color == other1.Color && this.Symbol == other1.Symbol)
            //    return true;
            //return false;
            return other is SymbolCard otherCard && this.Symbol == otherCard.Symbol;
                }
        public override void DrawingCard(string? s = null)
        {
            if (IsItVisible) {
            Console.ForegroundColor = Color; }
            base.DrawingCard(Symbol.ToString());
            Console.ForegroundColor =  ConsoleColor.White;
        }
    }
}
