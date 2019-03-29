using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_cSharp_h1
{
    public class Gazella : IPray
    {
        public int FleeSpeed { get; set; }
        public string Name { get; set; }

        public void Flee()
        {
            Console.WriteLine(Name + " flees away...");
        }
    }
}
