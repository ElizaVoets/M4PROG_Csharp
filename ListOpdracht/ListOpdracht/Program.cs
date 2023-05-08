namespace ListOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> birds = new List<string> { "Owl", "Crow", "Dog", "Parrot" };
            List<string> birds2 = new List<string> {"Seagull", "Dove" };

            birds.Remove("Dog");
            birds.AddRange(birds2);

            foreach(string bird in birds)
            {
                Console.WriteLine(bird);
            }
        }
    }
}