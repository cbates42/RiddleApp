//found how to grab keyvaluepair from https://www.tutorialsteacher.com/csharp/csharp-dictionary

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiddleApp.Level
{
    public abstract class LevelBase
    {
        public Dictionary<string, string> riddles { get; set; }
        public int currentIndex;

        public LevelBase()
        {
            riddles = new Dictionary<string, string>();
        }

        public abstract void PrintRiddle();
        public virtual void SetCurrentIndex(int index)
        {
            currentIndex = index;
        }
        public virtual KeyValuePair<string, string> GetRiddle(Dictionary<string, string> riddles, int currentIndex)
        {
            var riddle = riddles.ElementAt(currentIndex);
            return riddle;
        }


    }
}

