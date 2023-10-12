using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSVEngine
{
   public class Phone
    {
        [JsonPropertyName("Type")]
        public string Type;

        [JsonPropertyName("number")]
        public string Number;

        [JsonPropertyName("CanContact")]
        public string CanContact;

    }
}
