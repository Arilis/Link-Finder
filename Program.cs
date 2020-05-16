using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Link_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Link Finder v1.0 | Links Found: 0";
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\output.txt", String.Empty);
            int counter = 0;
            string line;
            StreamReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\input.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("://") || line.Contains("https://") || line.Contains("http://"))
                {
                    Console.WriteLine(line);
                    using (StreamWriter sw = File.AppendText(Directory.GetCurrentDirectory() + "\\output.txt"))
                    {
                        sw.WriteLine(line);
                    }
                }
                counter++;
                Console.Title = "Link Finder v1.0 | Links Found: " + counter;
            }

            file.Close();
            Console.ReadLine();
        }
    }
}
