using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elephant
{
    internal class Elephant
    {
        public int EarSize;
        public string Name;
        public void WhoAmI()
        {
            Console.WriteLine("My name is " + Name + ".");
            Console.WriteLine("My ears are " + EarSize + " inches tall. ");
        }

        public void HearMassage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(Name + " heard a massage ");
            Console.WriteLine(whoSaidIt.Name + " said this: " + message);

        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMassage(message, this);
        }

    }
}
