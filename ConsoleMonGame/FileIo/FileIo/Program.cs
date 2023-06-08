namespace FileIo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] content = File.ReadAllLines("leesdezefile.txt.txt");
            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }
            File.WriteAllText("Maia.txt", "Bazingaaaaaaaaa");
            Directory.CreateDirectory("Output");

            string FileName = @"Maia.txt";
            File.Move(FileName, Path.Combine("Output", FileName));

            
            
            
        }
    }
}