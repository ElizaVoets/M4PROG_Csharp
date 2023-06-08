namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Eliza\\OneDrive - Mediacollege Amsterdam\\Bewijzenmap\\jaar1\\periode1.4\\M4PROG\\M4PROG_Csharp";
            FileInfo di = new FileInfo("C:\\Users\\Eliza\\OneDrive - Mediacollege Amsterdam\\Bewijzenmap\\jaar1\\periode1.4\\M4PROG\\M4PROG_Csharp");
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach(FileInfo fi in dir.GetFiles())
            {
                Console.WriteLine(fi.FullName);
            }
            foreach(DirectoryInfo directory in dirs)
            {
                Console.WriteLine(directory.Name);
            }
        }
    }
}