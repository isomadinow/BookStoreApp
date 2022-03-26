using System;
using System.Xml;
using System.Xml.Serialization;
using BookStoreApp.BL.Model;

namespace BookStoreApp.BL.Provaider
{
    public class XmlDateProvider
    {
        static XmlSerializer xmlSzr = new XmlSerializer(typeof(BookStore));
        public static void SaveBookObject(string uri, BookStore book)
        {
            XmlWriterSettings xmlWrs = new XmlWriterSettings();
            xmlWrs.Indent = true;
            XmlWriter xmlWrt = XmlWriter.Create(uri, xmlWrs);
            xmlSzr.Serialize(xmlWrt, book);
            xmlWrt.Close();
        }

        public static BookStore LoadBookObject(string uri)
        {
            XmlReaderSettings xmlRds = new XmlReaderSettings();
            XmlReader xmlRdr = XmlReader.Create(uri, xmlRds);
            BookStore book = xmlSzr.Deserialize(xmlRdr) as BookStore;
            xmlRdr.Close();
            return book;
        }

        public static string GetXmlCode(string XmlFileName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XmlFileName);
            return xmlDoc.InnerXml;
        }
    }
}
