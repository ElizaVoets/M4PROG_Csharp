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
        
        
        public int health { get; set; }
        public int energy { get; set; }
        public string name { get; set; }
        internal Elements weakness { get; set; }

        public List<Skill> skills { get; set; }


        public ConsoleMon(int health, int energy, string name, Elements weakness)
        {
            this.health = health;
            this.energy = energy;
            this.name = name;   
            this.weakness = weakness;
        }

        public ConsoleMon()
        {

        }

        public void TakeDamage(int damage)
        {

            health -= damage;

        }
        public void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
    }
}
