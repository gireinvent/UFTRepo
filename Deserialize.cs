//CarCollection cars = null;
using System.Xml;  
using System.Xml.Serialization;
using System.IO;

namespace UFTRepo
{
    
    public class xml_Deserializer
    {
         static void Main(string[] args)
         {
             string path = @"C:\UFTRepo\Repository_Salesforce.xml";

                //XmlSerializer serializer = new XmlSerializer(typeof(ObjectRepository));
                string text = System.IO.File.ReadAllText(@"C:\UFTRepo\Repository_Salesforce.xml");
                XmlReader reader =  XmlReader.Create(path);
                XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ObjectRepository));
                ObjectRepository response =  (ObjectRepository)serializer.Deserialize(reader);
            //StreamReader reader = new StreamReader(path);

                // using(TextReader sr = new StringReader(text))
                // {
                //     //XmlSerializer serializer = new XmlSerializer(typeof(Person));
                //     //Person person = (Person)serializer.Deserialize(reader);
                //         XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ObjectRepository));
                //         ObjectRepository response =  (ObjectRepository)serializer.Deserialize(sr);
                //         //Console.WriteLine(response.bar);
                // }
         
         
          //  string strxml = reader.ReadToEndAsync();
          //  ObjectRepository cars = (ObjectRepository)serializer.Deserialize(reader);
            // reader.Close();
         }
               
    }

}