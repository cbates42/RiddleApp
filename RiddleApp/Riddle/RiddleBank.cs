using System.Security.Cryptography.X509Certificates;

namespace RiddleApp.Riddle
{
    internal class RiddleBank
    {
        public int currentIndex;
        public Dictionary<string, string> riddles; 

        public RiddleBank()
        {
            
            riddles = new Dictionary<string, string>();
            riddles.Add("How many fire-type pokemon can be caught within the storyline of Pokemon Diamond and Pearl? \n1. 3 2. 6  3. 2  4. 7", "3");
            riddles.Add("There is a pokemon that can evolve into a permanent fourth stage. \n 1. True. 2. False.", "2");
            riddles.Add("What pokemon has the highest speed?\n 1. Deoxys, 2. Ninjask, 3. Dragapult 4. Pheromosa", "1");
            riddles.Add("What pokemon has the lowest speed?\n 1. Slowpoke, 2. Stakataka, 3. Trapinch, 4. Shuckle", "4");
            riddles.Add("Pokemon Teal and Crimson were the most recent mainline gmaes.\n1. True 2. False", "2");
            riddles.Add("Rhydon was one of the first pokemon designed.\n1. True 2. False", "1");

        }




        public bool CheckAnswer(string playerAnswer, KeyValuePair<string, string> riddle)
        {
            if (playerAnswer == riddle.Value)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is {riddle.Value}");
                return false;
            }
        }

    }
} 
