using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal class Board
    {
        public int BoardSize { get; set; }
        public BasicCard [] arrCards;

        public Board(int b, List<BasicCard> l)
        {
            arrCards = new BasicCard[b];
            Random random = new Random();
            for (int i = 0; i < b; i++)
            {
                int randomNumber = random.Next(0, b);
                while (arrCards[randomNumber] != null)
                {
                    randomNumber = random.Next(0, b);
                }

                arrCards[randomNumber] = l[i];
            }
        }

        public void InitializeTheBoard(List<BasicCard> l)
        {
            Random random = new Random();
            for (int i = 0; i < l.Count; i++)
            {
                int num = random.Next(0, BoardSize);
                while (arrCards[num] != null)
                    num = random.Next(0, BoardSize);
                 arrCards[num] = l[i];


            }
        }
        public void DrawingBoard()
        {
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (arrCards[k] != null)
                        arrCards[k].DrawingCard();
                    else
                        Console.Write("[ ]");
                    k++;
                }
                Console.WriteLine();
            }
        }
        public bool CardLocation(int userNum)
        {
            if (userNum > 17)
                return false;
            return true;

        }
        public bool IsACardInTheGame()
        {
            
            foreach (BasicCard card in arrCards)
            {
                if (card != null)
                    return true;
            }
            return false;
        }
    }
}
