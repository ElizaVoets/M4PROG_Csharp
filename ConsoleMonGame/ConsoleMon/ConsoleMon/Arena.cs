using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemon
{
    internal class Arena
    {
        internal void fight(ConsoleMon FighterA, ConsoleMon FighterB)
        {
            FighterA.skills[0].UseOn(FighterB, FighterA);
            Console.WriteLine($"{FighterA.name} used {FighterA.skills[0].name} on {FighterB.name}\n");
        
            FighterB.skills[0].UseOn(FighterA, FighterB);
            Console.WriteLine($"{FighterB.name} used {FighterB.skills[0].name} on {FighterA.name}\n");
        }
    }
}
