using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVEngine
{
    public abstract class BaseEngine
    {
        public virtual void BasicRead(string? delimiter, string path, string[] allFiles, string file)
        {
            //creates the path for the file that will be output
            var currentOutputFile = Path.Combine(path, Path.GetFileNameWithoutExtension(file) + "_output" + Path.GetExtension(file));
            using (StreamReader sr = new StreamReader(file))
            {
                //read the line
                var line = sr.ReadLine();
                while (line != null)
                {
                    //split the line based on the delimiter
                    var stats = line.Split(delimiter);
                    int num = 1;

                    //for each item that should be in the line increment a number for the fields
                    foreach (var item in stats)
                    {
                        using (StreamWriter sw = new StreamWriter(currentOutputFile, true))
                        {
                            sw.Write($"Field#{num}-");
                            num++;
                            sw.Write(item + " ");
                            sw.WriteLine("");
                        }
                    }

                    num = 0;
                    line = sr.ReadLine();
                }
            }
        }
    }
}
