using Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class ConsoleMon
    {
        
        
            public int health;
            public int energy;
            public string name;
            internal Elements weakness;
            private List<Skill> skills;

            

        public ConsoleMon()
        {

        }

        internal ConsoleMon(int health, int energy, string name, Elements weakness)
        {
            this.health = health;
            this.energy = energy;
            this.name = name;   
            this.weakness = weakness;
        }

        internal void TakeDamage(int damage)
            {
                health -= damage;

            }
            internal void DepleteEnergy(int energy)
            {
                this.energy -= energy;
            }
        }
}
