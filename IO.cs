using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVEngine
{
    internal class IO
    {                                      
        public string delimiter = "|";

        
        public IO()
        {                      
            // get path
            var path = Directory.GetCurrentDirectory() + @"\Files\"; 
            //make an array of all the files
            string[] files = Directory.GetFiles(path);

            using (StreamReader sr = new StreamReader(path))
            {
                //for each file
                foreach (var file in files)
                {
                    //read the line
                    var line = sr.ReadLine();
                    while (line != null)
                    {
                        //if the line has a | the delimiter is | 
                        if (line.Contains('|'))
                        {
                            delimiter = "|";
                        }
                        else 
                        {//if there's no | assume the delimiter is ,
                            delimiter = ",";
                        }

                        //split the line based on the delimiter
                        var stats = line.Split(delimiter);
                        int num = 1;

                        //for each item that should be in the line increment a number for the fields
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
