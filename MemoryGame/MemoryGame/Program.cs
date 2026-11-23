using System.Data;

namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the memory game!");
            List<BasicCard> listSymbol = new List<BasicCard>();
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = true, Color = ConsoleColor.Yellow, Symbol = '#' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = false, Color = ConsoleColor.Yellow, Symbol = '#' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = true, Color = ConsoleColor.Red, Symbol = '!' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = false, Color = ConsoleColor.Red, Symbol = '!' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = true, Color = ConsoleColor.Gray, Symbol = '#' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = false, Color = ConsoleColor.Gray, Symbol = '#' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = true, Color = ConsoleColor.Green, Symbol = '$' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = false, Color = ConsoleColor.Green, Symbol = '$' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = true, Color = ConsoleColor.Blue, Symbol = '&' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = false, Color = ConsoleColor.Blue, Symbol = '&' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = true, Color = ConsoleColor.Gray, Symbol = '*' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = false, Color = ConsoleColor.Gray, Symbol = '*' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = true, Color = ConsoleColor.Yellow, Symbol = '+' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = false, Color = ConsoleColor.Yellow, Symbol = '+' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = true, Color = ConsoleColor.Red, Symbol = '-' });
            listSymbol.Add(new SymbolCard() { IsItVisible = false, FirstOrSecond = false, Color = ConsoleColor.Red, Symbol = '-' });

            List<BasicCard> listSignal = new List<BasicCard>();

            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = false, Signal = 'A' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = true, Signal = 'A' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = false, Signal = 'C' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = true, Signal = 'C' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = false, Signal = 'R' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = true, Signal = 'R' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = false, Signal = 'B' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = true, Signal = 'B' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = false, Signal = 'P' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = true, Signal = 'P' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = false, Signal = 'D' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = true, Signal = 'D' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = false, Signal = 'M' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = true, Signal = 'M' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = false, Signal = 'N' });
            listSignal.Add(new SignalCard() { IsItVisible = false, FirstOrSecond = true, Signal = 'N' });

            List<BasicCard> listExercise = new List<BasicCard>();
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = false, Exercise = "6+2", Solution = 8 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = true, Exercise = "6+2", Solution = 8 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = false, Exercise = "2+2", Solution = 4 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = true, Exercise = "2+2", Solution = 4 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = false, Exercise = "6+3", Solution = 9 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = true, Exercise = "6+3", Solution = 9 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = false, Exercise = "1+2", Solution = 3 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = true, Exercise = "1+2", Solution = 3 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = false, Exercise = "5+2", Solution = 7 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = true, Exercise = "5+2", Solution = 7 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = false, Exercise = "5+5", Solution = 10 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = true, Exercise = "5+5", Solution = 10 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = false, Exercise = "1+1", Solution = 2 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = true, Exercise = "1+1", Solution = 2 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = false, Exercise = "1+0", Solution = 1 });
            listExercise.Add(new ExerciseCard() { IsItVisible = false, FirstOrSecond = true, Exercise = "1+0", Solution = 1 });

          
            foreach (var item in listSymbol)
            {
                item.DrawingCard();
            }
            Console.WriteLine("");
            foreach (var item in listSignal)
            {
                item.DrawingCard();
            }
            Console.WriteLine("");

            foreach (var item in listExercise)
            {
                item.DrawingCard();
            }
            Dictionary<typeGame, List<BasicCard>> cards = new Dictionary<typeGame, List<BasicCard>>();
            cards.Add(typeGame.signal, listSignal);
            cards.Add(typeGame.exercise, listExercise);
            cards.Add(typeGame.symbol, listSymbol);
            Game game = new Game(cards);
            game.GameMov();
        }
    }
}
