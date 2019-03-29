using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_cSharp_h1
{
    public class Fish : IPray, IPredator
    {
        public string Name { get; set; }
        public int FleeSpeed { get; set; }
        public int AttackSpeed { get; set; }

        public void Flee()
        {
            Console.WriteLine(Name + " flees away...");
        }

        public void Attack(IPray pray)
        {
            if (this.AttackSpeed > pray.FleeSpeed)
                Console.WriteLine(Name + " catches " + pray.Name);
            else
                Console.WriteLine(pray.Name + " escapes from " + Name);
        }
    }
}
