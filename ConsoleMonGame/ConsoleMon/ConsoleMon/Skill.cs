using Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Skill
    {

        public int damage;
        public int energyCost;
        public string name;
        internal Elements element;

        public Skill()
        {

        }

        internal Skill(int damage, int energyCost, string name, Elements element)
        {
            this.damage = damage;
            this.energyCost = energyCost;
            this.name = name;
            this.element = element;
        }

        internal void UseOn(ConsoleMon tarrget, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            tarrget.TakeDamage(damage);

            if (tarrget.weakness == element)
            {
                tarrget.TakeDamage(damage/2);
            }
        }
    }
    }

