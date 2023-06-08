namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("stringSplit.txt");

            string[] keyvalue = content.Split(":");
            string[] cijfersPerVak = keyvalue[1].Split(",");
            foreach (string line in keyvalue)
            {
                Console.WriteLine(line);
            }
            foreach (string line in cijfersPerVak) 
            {
                Console.WriteLine(line);
            }

        }
    }
}