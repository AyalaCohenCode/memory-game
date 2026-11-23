using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal abstract class MainActor
    {
        public int NumberOfPoints { get; set; }
        public List<BasicCard> listCards;
        public virtual string? YourName { get; set; }

        //protected MainActor(int np, string n)
        //{
        //    this.NumberOfPoints = np;
        //    this.Name = n;
        //    listCards = new List<BasicCard>();
        //}
  
        protected MainActor()
        {
            listCards = new List<BasicCard>();
        }
        public virtual void name() { }
        
        public abstract int liftCards();
        public void ShowCards()
        {
            for (int i = 0; i < listCards.Count; i++)
            {
                listCards[i].DrawingCard();
            }
        }
    }
}
