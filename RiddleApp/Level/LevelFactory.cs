using RiddleApp.Riddle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiddleApp.Level
{
    internal class LevelFactory
    {
        private List<LevelBase> levels;

        public LevelFactory()
        {
            levels = new List<LevelBase>();
            RiddleBank riddleBank = new RiddleBank();

            foreach(var riddle in riddleBank.riddles)
            {
                levels.Add(new Level(riddle.Key, riddle.Value));
            }
        }

        public LevelBase GetLevel(int index)
        {
            if (index < levels.Count)
            {
                levels[index].SetCurrentIndex(index);
                return levels[index];
            }

            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }


    }




}
