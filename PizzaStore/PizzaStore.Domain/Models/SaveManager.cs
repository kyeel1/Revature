using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PizzaStore.Domain
{
    public class SaveManager
    {
        private string _path = @"data/SaveFile.xml";
        public Order Read(string user)
        {
            _path = $@"data/{user}SaveFile.xml";
            var reader= new StreamReader(_path);
            var xml = new XmlSerializer(typeof(Order));
            
            return xml.Deserialize(reader) as Order;

        }
        public void Write(Order orders, string user)
        {
            _path = $@"data/{user}SaveFile.xml";
            var writer = new StreamWriter(_path);
            var xml = new XmlSerializer(typeof(Order));
            
            xml.Serialize(writer,orders);

        }
    }
}