﻿using Pokemon;
using System.Xml.Linq;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestConsoleMonFunctions();
            TestSkillFunctions();
            TestConstructors();
            TestFactoryFunctions();
            
        }
        static void TestFactoryFunctions()
        {
            Console.WriteLine("TestFactoryFunctions");
            ConsoleMonFactory factory = new ConsoleMonFactory();
            factory.Load("monsterdata.txt");
        }
        static void TestConstructors()
        {
            Console.WriteLine("TestConstructors");
            ConsoleMon mon = new ConsoleMon(200, 200, "ConsoleColorMon", Elements.Earth);

            Console.WriteLine(mon.energy == 200);
            Console.WriteLine(mon.name == "ConsoleColorMon");
            Console.WriteLine(mon.health == 200);
            Console.WriteLine(mon.weakness == Elements.Earth);


            Skill skill = new Skill(90, 80, "FireBlade", Elements.Fire);
            Console.WriteLine(skill.energyCost == 80);
            Console.WriteLine(skill.name == "FireBlade");
            Console.WriteLine(skill.damage == 90);
            Console.WriteLine(skill.element == Elements.Fire);

        }
        static void TestConsoleMonFunctions()
        {
            Console.WriteLine("TestConsoleMonFunctions");
            ConsoleMon mon = new ConsoleMon();
            mon.TakeDamage(100);
            mon.DepleteEnergy(20);

            Console.WriteLine(mon.health == -100);

            Console.WriteLine(mon.energy == -20);
        }
        static void TestSkillFunctions()
        {
            Console.WriteLine("TestSkillFunctions");
            ConsoleMon casterMon = new ConsoleMon();
            ConsoleMon targetMon = new ConsoleMon();
            Skill skill = new Skill()
            {
                damage = 100,
                energyCost = 20,
            };
            skill.UseOn(targetMon, casterMon);

            Console.WriteLine(targetMon.health == -150);

            Console.WriteLine(casterMon.energy == -20);
        }
    }

}