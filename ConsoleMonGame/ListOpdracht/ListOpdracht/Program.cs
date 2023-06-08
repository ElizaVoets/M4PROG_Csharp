namespace ListOpdracht
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            List<string> birds = new List<string>(new string[] {"Owl", "Parrot", "Crow", "Seagul"});
            List<string> birds2 = new List<string>(new string[] { "Pigon", "Ytsheiro" });

            birds.AddRange(birds2);
            birds.Remove(birds2[1]);

            birds.ForEach(Console.WriteLine);
        }
        
    }
    
}