using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal abstract class BasicCard
    {
        public bool IsItVisible { get; set; }//גלוי

        public bool FirstOrSecond { get; set; }//האם ראשון
        public override bool Equals(object? obj)
        {
            BasicCard other = obj as BasicCard;
            if (other != null) //אם הצלחתי להמיר את הכרטיס
                return other.IsItVisible == this.IsItVisible && this.FirstOrSecond != other.FirstOrSecond;
            return false;
        }
        public abstract bool CheckMatch(BasicCard other);

        public virtual void DrawingCard(string? s=null)
        {
            Console.Write("[");
            if(IsItVisible)
                Console.Write(s);
            else
              Console.Write("?");
            Console.Write("]");
        }
    }
}
