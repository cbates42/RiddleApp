using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiddleApp
{
    internal class PotionReceiver : IReceiver
    {


        public IReceiver nextReceiver { get; set; }

        public void ProcessRequest(Item item)
        {
            if (item.Name.Contains("Potion"))
            {
                Console.WriteLine($"You have the Potion Item: {item.Name}");
            }
            else
            {
                nextReceiver.ProcessRequest(item);
            }
        }

        public void SetNextReceiver(IReceiver receiver)
        {
            nextReceiver = receiver;
        }
    }
}
