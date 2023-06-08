namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\safoa\\OneDrive\\Desktop\\ma\\Periode4\\Prog\\2023P4ProgCs2";
            FileInfo di = new FileInfo("C:\\Users\\safoa\\OneDrive\\Desktop\\ma\\Periode4\\Prog\\2023P4ProgCs2");
            DirectoryInfo dir = new DirectoryInfo (path);
            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (FileInfo fi in dir.GetFiles ())
            {
                Console.WriteLine (fi.FullName);
            }
            foreach (DirectoryInfo directory in dirs) 
            { 
                Console.WriteLine (directory.Name);
            }
        }
    }
}