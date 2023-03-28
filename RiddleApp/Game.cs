//referenced Week 8 Demo

using RiddleApp.Level;
using RiddleApp.Riddle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace RiddleApp
{
    internal class Game
    {

        private List<LevelBase> levels;
        public int currentIndex = 0;
        public int correctAnswers = 0;
        List<Item> items = new List<Item>();
        IReceiver goldReceiver = new GoldReceiver();
        IReceiver swordReceiver = new SwordReceiver();
        IReceiver potionReceiver = new PotionReceiver();
        Item item = new Item("default sword");
        Random random = new Random();
      

        public Game()
        {
            RiddleBank riddles = new RiddleBank();
            levels = new List<LevelBase>();
            LevelFactory factory = new LevelFactory();
            Player player = Player.Instance();
            Player.StartTimer();
         
            swordReceiver.SetNextReceiver(goldReceiver);
            goldReceiver.SetNextReceiver(potionReceiver);

            for (int i = 0; i < 6; i++)
            {
                levels.Add(factory.GetLevel(i));
            }

            foreach (LevelBase level in levels)
            {
                Console.WriteLine($"{Player.lives}lives\n");
                Player.StartTimer();
                level.PrintRiddle();
                string playerAnswer = Console.ReadLine();
                bool isCorrect = riddles.CheckAnswer(playerAnswer, level.GetRiddle(riddles.riddles, currentIndex));
                if (isCorrect)
                {
                    int randomNumber = random.Next(0, 6);
                    Console.WriteLine("Correct!");
                    items.Add(item.randomItem(random.Next(0, 6)));
                    Console.WriteLine($"You have received {items[currentIndex].Name}!");

                    if(currentIndex > 5)
                    {
                        currentIndex = 5;
                    }
                    correctAnswers++;
                }
                else
                {
                    Player.DecrementLife();
                    Console.WriteLine("Incorrect!");

                    if (Player.lives <= 0)
                    {
                        Console.WriteLine("Game over! You have run out of lives.");
                        break;
                    }
                }
                currentIndex++;
            }
            foreach(Item item in items)
            {
                swordReceiver.ProcessRequest(item);
            }
            Console.WriteLine($"You got {correctAnswers} and had {Player.lives} remaining!");
        }
    }
}

