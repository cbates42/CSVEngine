using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSVEngine
{
    [XmlRoot(ElementName = "menu")]
    public class Grocery
    {
        [XmlElement(ElementName = "item")]
        public List<GroceryItem> Item { get; set; }


    }
}
