using System;
using System.Xml;
using System.Xml.Serialization;

namespace BookStoreApp.BL.Provaider
{
    public static class XmlDataProvider<T>
         where T : class, new()
    {
        public static XmlSerializer xmlSzr = new XmlSerializer(typeof(T));

        public static void SaveObject(string uri, T obj)
        {
            XmlWriterSettings xmlWrs = new XmlWriterSettings();
            xmlWrs.Indent = true;
            XmlWriter xmlWrt = XmlWriter.Create(uri, xmlWrs);
            xmlSzr.Serialize(xmlWrt, obj);
            xmlWrt.Close();
        }

        public static T LoadObject(string uri)
        {
            XmlReaderSettings xmlRds = new XmlReaderSettings();
            XmlReader xmlRdr = XmlReader.Create(uri, xmlRds);
            T obj = xmlSzr.Deserialize(xmlRdr) as T;
            xmlRdr.Close();
            return obj;
        }
    }
}
