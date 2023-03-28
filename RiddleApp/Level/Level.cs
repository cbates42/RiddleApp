using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RiddleApp.Level
{
    internal class Level : LevelBase
    {


        public Dictionary<string, string>  riddles;
        private string Text;
        private string answer;
        
        public Level(string text, string answer)
        {

            Text = text;
            this.answer = answer;
        }

        public override void PrintRiddle()
        {
            Console.WriteLine($"Question {currentIndex + 1}: {Text}");
        }
    }
}
