using System;
using System.IO;

namespace Filhandeling
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn;
            string path = "fileWithNames.txt";

            Console.WriteLine("Ange ett namn.");
            namn = Console.ReadLine();

            // using (StreamWriter sw = File.CreateText(path))
            // {
            //     sw.WriteLine(namn);
            // }

            File.AppendAllText(path, namn);

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            Console.ReadLine();
        }
    }
}
