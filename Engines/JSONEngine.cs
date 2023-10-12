using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSVEngine.Engines
{
    internal class JSONEngine : BaseEngine
    {

        public override void BasicRead(string? delimiter, string path, string[] allFiles, string file)
        {
            var currentOutputFile = Path.Combine(path, Path.GetFileNameWithoutExtension(file) + "_output" + Path.GetExtension(file));
            using (StreamReader sr = new StreamReader(file))
            {
                //deserializes currentstudent into student type
                Student currentStudent = JsonConvert.DeserializeObject<Student>(sr.ReadToEnd());



                using (StreamWriter sw = new StreamWriter(currentOutputFile, true))
                {
                    sw.WriteLine($"Line#1 : {currentStudent.ToString()}");
                }
             
            }


        }
    } 
}

