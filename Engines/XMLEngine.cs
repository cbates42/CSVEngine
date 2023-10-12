using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSVEngine.Engines
{
    internal class XMLEngine : BaseEngine
    {
        
        public override void BasicRead(string? delimiter, string path, string[] allFiles, string file)
        {
            //gets new path 
            var currentOutputFile = Path.Combine(path, Path.GetFileNameWithoutExtension(file) + "_output" + Path.GetExtension(file));

            using (var fs = File.Open(file, FileMode.Open))
            {
                //deserializes xml file into the grocery file
                XmlSerializer serializer = new XmlSerializer(typeof(Grocery));
                var inventory = (Grocery)serializer?.Deserialize(fs);

                using (StreamWriter sw = new StreamWriter(currentOutputFile, true))
                {
                    var linecount = 1;
                    foreach (var item in inventory.Item)
                    {
                        sw.WriteLine($"Line#{linecount++} : Item info => {item.Name} {item.Price}/{item.Uom}");
                    }
                }
             }


        }

    }
}
