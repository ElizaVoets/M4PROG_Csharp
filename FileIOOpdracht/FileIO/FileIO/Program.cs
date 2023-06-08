using System.Xml;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] content = File.ReadAllLines("LeesDezeTekstFile.txt");
            string FileName = @"MijnNieuweFile.txt";
            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }

            File.WriteAllText("MijnNieuweFile.txt", "Bazinga.");
            Directory.CreateDirectory("Output");
            File.Move(FileName, Path.Combine("Output", FileName));
            
            
        }
    }
}