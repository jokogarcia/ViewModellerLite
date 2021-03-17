using System;
using System.Xml;

namespace ViewModellerCore
{
    public static class ViewModeller
    {
        public static string CreateCommand(string s)
        {
            return string.Format(StringConstants.CommandTemplate, GetPrivateName(s), GetPublicName(s));
        }
        public static string CreateTCommand(string s, string argType)
        {
            return string.Format(StringConstants.TCommandTemplate, GetPrivateName(s), GetPublicName(s),argType);
        }
        public static string CreateProperty (string s, string propType)
        {
            return string.Format(StringConstants.PropertyTemplate, propType, GetPrivateName(s), GetPublicName(s));
        }
        public static string GetPrivateName(string s)
        {
            return "_" + char.ToLower(s[0]) + s.Substring(1);
        }
        public static string GetPublicName(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        public static string[] BindedPropertiesExtractor(string xml)
        {
            XmlDocument doc = new XmlDocument();
            xml = xml.Replace(" ", "");
            doc.LoadXml(xml);
            foreach(XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (var attribute in node.Attributes)
                {
                    Console.WriteLine("attr: "+attribute);
                }
            }
            return new string[] { "finished" };
        }
    }
}
