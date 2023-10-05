using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVEngine
{
    internal class IO
    {//                                             
        public string delimiter = "|";
        string path = Path.Combine(Directory.GetCurrentDirectory(), "Files");
        
        public IO()
        {
            //                                             
          //  var path = Directory.GetCurrentDirectory() + @"\Files\ SamplePipe.txt"; 
            string[] files = Directory.GetFiles(path);

            using (StreamReader sr = new StreamReader(path))
            {
                foreach (var file in files)
                {
                    var line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line.Contains('|'))
                        {
                            delimiter = "|";
                        }
                        else 
                        {
                            delimiter = ",";
                        }

                        var stats = line.Split(delimiter);
                        int num = 1;

                        foreach (var item in stats)
                        {
                            Console.Write($"Field#{num}-");
                            num++;
                            Console.Write(item + " ");
                        }
                        Console.WriteLine("");
                        num = 0;
                        line = sr.ReadLine();
                    }
                }
            }

            Console.Read();
        }


    }
}
