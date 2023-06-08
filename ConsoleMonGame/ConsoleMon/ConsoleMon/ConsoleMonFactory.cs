using Program;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class ConsoleMonFactory
    {
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
    }
}
