using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVEngine
{
    internal class IO
    {//                                             
      
        public IO() 
        {
            //                                              v  add whatever the directory is here later
            var path = Directory.GetCurrentDirectory();

            using(StreamReader sr = new StreamReader(path))
            {
                var line = sr.ReadLine();
                while(line != null)
                {
                    var stats = line.Split("|");

                    foreach (var item in stats)
                    {
                        Console.Write(item + " ");
                    }
                    line = sr.ReadLine();
                }
                   
            }

            Console.Read();
        }
    








    }
}
