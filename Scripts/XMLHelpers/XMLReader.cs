using System.Xml.Linq;

namespace UnityHelpers.XMLHelpers
{
    public static class XMLReader
    {
        public static string GetDataFromXMLFile(string path, string xmlTag)
        {
            try
            {
                return XElement.Load(path).Element(xmlTag).Value;
            }
            catch (System.Exception)
            {
                return "";
            }
        }
    }
}