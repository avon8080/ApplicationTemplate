using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate
{
    public class Show : CollectiveDisplay
    {
        public int Season { get; set; }
        public int Episode { get; set; }
        public string writers { get; set; }
        public override void Display()
        {
            string fileName = "shows.csv";
            StreamReader sr = new StreamReader(fileName);
            if (File.Exists(fileName))
            {
                while (!sr.EndOfStream)
                {
                    var lines = sr.ReadLine();

                    Console.WriteLine(lines);
                }
                sr.Close();
            }
        }
    }
}
