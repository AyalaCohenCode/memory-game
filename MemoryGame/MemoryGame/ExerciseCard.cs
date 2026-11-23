using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal class ExerciseCard:BasicCard
    {
        public string Exercise { get; set; }
        public int Solution { get; set; }

        public ExerciseCard()
        {
            
        }
        public ExerciseCard(int s,string e)
        {
            this.Solution = s;
            this.Exercise = e;
        }
        public override bool CheckMatch(BasicCard other)
        {
            ExerciseCard x = other as ExerciseCard;
            if (this.Equals(other) && this.Exercise == x.Exercise && this.Solution == x.Solution)
                return true;
            return false;
        }
        public override void DrawingCard(string? s = null)
        {
            if ((this.FirstOrSecond))
            {
                base.DrawingCard(Exercise);
            }
            else
            {
                base.DrawingCard(Exercise.ToString());
            }

        }
    }
}
