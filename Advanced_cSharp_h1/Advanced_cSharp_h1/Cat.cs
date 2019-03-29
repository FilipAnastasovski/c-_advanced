using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_cSharp_h1
{
    public class Cat : IPredator
    {
        public int AttackSpeed { get; set; }
        public string Name { get; set; }

        public void Attack(IPray pray)
        {
            if (AttackSpeed > pray.FleeSpeed)
            {
                Console.WriteLine(Name + " catches " + pray.Name);
            }
            else
            {
                Console.WriteLine(pray.Name + " escapes from " + Name);
            }
        }
    }
}
