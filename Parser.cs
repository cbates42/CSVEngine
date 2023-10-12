// referenced json & xml logic from powerpoint
// referenced how to add output here https://stackoverflow.com/questions/4804990/getting-file-names-without-extensions


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CSVEngine.Engines;

namespace CSVEngine
{
    internal class Parser
    {
        //create the base engine for later
        public BaseEngine Engine;
        public string delimiter = "";

        public Parser()
        {
            //gets path and puts everything in that path in an array
            var path = Directory.GetCurrentDirectory() + @"\Files";
            string[] allFiles = Directory.GetFiles(path).ToArray();

            //looks through each file in the array of paths
            foreach (string file in allFiles)
            {
                if (file != null)
                {
                    //checks the extension and runs the appropriate engine for the file type
                    // non-txt and csv files don't need a delimiter
                    switch (Path.GetExtension(file))
                    {
                        case ".txt": Engine = new BasicEngine(); delimiter = "|"; break;
                        case ".csv": Engine = new BasicEngine(); delimiter = ","; break;
                        case ".xml": Engine = new XMLEngine(); break;
                        case ".JSON": Engine = new JSONEngine(); break;
                    }

                    if (Engine.GetType() == typeof(BasicEngine))
                    {
                        Engine.BasicRead(delimiter, path, allFiles, file);
                    }

                    if (Engine.GetType() == typeof(XMLEngine))
                    {
                        Engine.BasicRead(null, path, allFiles, file);
                    }

                    if (Engine.GetType() == typeof(JSONEngine))
                    {
                        Engine.BasicRead(null, path, allFiles, file);
                    }
                }
            }
        }
    }


            
        
    }

