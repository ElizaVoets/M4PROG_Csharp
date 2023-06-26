using Program;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class ConsoleMonFactory
    {
        internal List<ConsoleMon> LoadJson(string datafile)
        {
            string json = File.ReadAllText(datafile);
            Console.WriteLine(json);
            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);
            return templates;
        }
        internal void Load(string datatype)
        {

            
            string[] lines = File.ReadAllLines(datatype);
            foreach (string line in lines)
            {
                ConsoleMon datamon = new ConsoleMon();
                Console.WriteLine(line);
                string[] typesplit = line.Split('|');
                string[] consolemonData = typesplit[0].Split(",");
                foreach (string type in typesplit)
                {
                    Console.WriteLine(type); 
                }
            }
            
        }

        internal Skill CopySkill(Skill CopyFrom)
        {
            Skill copyResult = new Skill();
            copyResult.name = CopyFrom.name;
            copyResult.damage = CopyFrom.damage;
            copyResult.energyCost = CopyFrom.energyCost;
            copyResult.element = CopyFrom.element;

            return copyResult;
        }

        internal ConsoleMon CopyConsoleMon(ConsoleMon CopyFrom)
        {
            ConsoleMon CopyResult = new ConsoleMon();
            CopyResult.name = CopyFrom.name;
            CopyResult.health = CopyFrom.health;
            CopyResult.energy = CopyFrom.energy;
            CopyResult.weakness = CopyFrom.weakness;
            CopyResult.skills= new List<Skill>();

            for (int i = 0; i < CopyFrom.skills.Count; i++)
            {
                CopyResult.skills.Add(CopySkill(CopyFrom.skills[i]));
            }

            return CopyResult;
        }
    }
}
