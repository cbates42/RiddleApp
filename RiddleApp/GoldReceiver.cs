using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiddleApp
{
    public class GoldReceiver : IReceiver
    {
        public IReceiver nextReceiver { get; set; }

        public void ProcessRequest(Item item)
        {
            if (item.Name.Contains("Gold"))
            {
                Console.WriteLine($"You have the Gold Item: {item.Name}");
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
