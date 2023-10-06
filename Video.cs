using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate
{
    public class Video : CollectiveDisplay
    {
        
        public string format { get; set; }
        public int length { get; set; }
        public int[] regions { get; set; }
        public override void Display()
        {
            string fileName = "videos.csv";
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
