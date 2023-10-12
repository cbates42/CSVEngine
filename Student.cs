using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSVEngine
{
    public class Student
    {
        [JsonPropertyName("firstName")]
        public string FirstName;

        [JsonPropertyName("lastName")]
        public string LastName;

        [JsonPropertyName("isEnrolled")]
        public bool isEnrolled;

        [JsonPropertyName("YearsEnrolled")]
        public int YearsEnrolled;

        [JsonPropertyName("address1")]
        public Address Address1;

        [JsonPropertyName("address2")]
        public Address Address2;

        [JsonPropertyName("phoneNumbers")]
        public List<Phone> PhoneNumbers = new List<Phone>();



    }
}
