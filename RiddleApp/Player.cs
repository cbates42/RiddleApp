using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace RiddleApp
{
    public class Player
    {
        public static Player? instance;
        public static int lives;
        private static System.Timers.Timer timer;
        public int TimeRemaining;
        private Player()
        {
          
    
        }
        public static Player Instance()
        {
            if (instance == null)
            {
                instance = new Player();
                lives = 5;
        
            }
            return instance;
        }

        public static void DecrementLife()
        {
            lives--;
        }

        public static void StartTimer()
        {
            timer = new System.Timers.Timer(5 * 60 * 1000);
            timer.AutoReset = false;
            timer.Enabled = true;
        }
    }
}
