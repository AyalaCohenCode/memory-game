using MemoryGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    enum typeGame
    {
        exercise, signal, symbol
    }
    internal class Game
    {
        private Board board;

        private Dictionary<typeGame, List<BasicCard>> cards;
        public List<MainActor> ListPlayers;
        public int index { get; set; }
        public typeGame TypeGame;

        public Game(Dictionary<typeGame, List<BasicCard>> cards)
        {
            MainActor mainActor = new UserPlayer();
            MainActor m;
            Console.WriteLine("do you went another player? y=1, n=2");
            int result = int.Parse(Console.ReadLine());
            if (result == 1)
                m = new UserPlayer();
            else
                m = new ComputerPlayer();

            Console.WriteLine("choes what you wet to play exercise=1, signal= 2, symbol=3");
            int result2 = int.Parse(Console.ReadLine());
            if(result2 == 1)
                this.TypeGame=typeGame.exercise;
            if(result2 == 2)
                this.TypeGame = typeGame.signal;
            if(result2== 3)
                this.TypeGame = typeGame.symbol;

            this.ListPlayers = new List<MainActor>();
            this.ListPlayers.Add(mainActor);
            this.ListPlayers.Add(m);
            this.cards = cards;
            index = 0;
            //this.TypeGame = typeGame.symbol;
            board = new Board(16, cards[TypeGame]);


            
        }
       
        public bool FoundCouple(int index1, int index2)
        {

            if (!board.arrCards[index1].CheckMatch(board.arrCards[index2]))
                return false;
            ListPlayers[index].listCards.Add(board.arrCards[index1]);
            ListPlayers[index].listCards.Add(board.arrCards[index2]);
            board.arrCards[index1] = null;
            board.arrCards[index2] = null;
            ListPlayers[index].NumberOfPoints += 10;
            return true;

        }

        public void win()
        {
            if (ListPlayers[0].NumberOfPoints > ListPlayers[1].NumberOfPoints)
            {
                Console.WriteLine(ListPlayers[0].YourName);
                ListPlayers[0].ShowCards();
            }
            else
                Console.WriteLine(ListPlayers[1].YourName);
            ListPlayers[1].ShowCards();
        }

        public void GameMov()
        {
            board.DrawingBoard();
            while (this.board.IsACardInTheGame())
            {

                Console.WriteLine($"It's {ListPlayers[index].YourName} turn");
                int c = ListPlayers[index].liftCards();
                while (board.arrCards[c] == null)
                {
                    Console.WriteLine("The card is empty. Press another card.");
                    c = ListPlayers[index].liftCards();
                }
                while (!board.CardLocation(c))
                {
                    Console.WriteLine("Invalid position, try again.");
                    c = ListPlayers[index].liftCards();
                }

                board.arrCards[c].IsItVisible = true;
                board.DrawingBoard();
                Console.WriteLine();
                int c2 = ListPlayers[index].liftCards(); 
                while (board.arrCards[c2] == null)
                {
                    Console.WriteLine("The card is empty. Press another card.");
                    c2 = ListPlayers[index].liftCards();
                }
                while (!board.CardLocation(c2))
                {
                    Console.WriteLine("Invalid position, try again.");
                    c2 = ListPlayers[index].liftCards();
                }
                board.arrCards[c2].IsItVisible = true;
                board.DrawingBoard();


                bool b = FoundCouple(c, c2);
                bool flag = false;

                for (int i = 0; i < board.arrCards.Length && !false; i++)
                {
                    if (board.arrCards[i] != null)
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine("!!!!!!!!");
                    break;
                }

                if (!b)
                {
                    board.arrCards[c].IsItVisible = false;
                    board.arrCards[c2].IsItVisible = false;
                }
                if (index == 0)
                    index = 1;
                else
                    index = 0;

            }
            win();
        }

    }
}