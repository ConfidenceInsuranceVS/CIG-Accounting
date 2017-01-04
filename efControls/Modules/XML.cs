using System.Xml.Linq;
using System.Linq;
using System.IO;
using System;

namespace efControls
{
    public class XML
    {
        //public static string Read(string xmlFile, string element)
        //{
        //    var result = string.Empty;
        //    try
        //    {
        //        var doc = XDocument.Load(xmlFile).Root;
        //        result = doc.Descendants(element).FirstOrDefault().Value;
        //    }
        //    catch (Exception)
        //    {
        //        result = string.Empty;
        //    }
        //    return result;
        //}
        //public static void Write(string xmlFile, string element, string value)
        //{
        //    Stream stream;
        //    XDocument doc;
        //    if (!File.Exists(xmlFile))
        //    {
        //        stream = File.Create(xmlFile);
        //        doc = new XDocument();
        //        var root = new XElement("ROOT");
        //        doc.Add(root);
        //    }
        //    else
        //    {
        //        stream = File.Open(xmlFile, FileMode.Open);
        //        doc = XDocument.Load(stream);
        //    }
        //    if (doc.Root.Element(element) != null)
        //    {
        //        doc.Root.Element(element).Remove();
        //    }
        //    doc.Root.Add(new XElement(element, value));


        //    stream.SetLength(0);
        //    doc.Save(stream);
        //    stream.Close();
        //}
        //public static void Delete(string xmlFile, string element)
        //{
        //    Stream stream;
        //    XDocument doc;
        //    try
        //    {
        //        stream = File.Open(xmlFile, FileMode.Open);
        //        doc = XDocument.Load(stream);

        //        if (doc.Root.Element(element) != null)
        //        {
        //            doc.Root.Element(element).Remove();
        //        }
        //        stream.SetLength(0);
        //        doc.Save(stream);
        //        stream.Close();
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        /////////////////
        public static void Create(string document)
        {
            XDocument doc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment(string.Format("{0} Preferences File", App.Name)),
                    new XElement(string.Format("{0}Preferences", App.Name)));
            doc.Save(document);
        }
        //
        public static void Write(string document, string element, string key, string value)
        {
            if (!File.Exists(document)) { Create(document); }

            XDocument doc = XDocument.Load(document);
            if (doc.Root.Element(element) == null)
            {
                doc.Root.Add(new XElement(element));
                doc.Root.Element(element).Add(new XElement(key, value));
            }
            else
                doc.Root.Element(element).SetElementValue(key, value);

            doc.Save(document);
        }
        public static void Write(string document, string element, string subElement, string key, string value)
        {
            if (!File.Exists(document)) { Create(document); }

            XDocument doc = XDocument.Load(document);
            if (doc.Root.Element(element) == null)
                doc.Root.Add(new XElement(element));

            if (doc.Root.Element(element).Element(subElement) == null)
            {
                doc.Root.Element(element).Add(new XElement(subElement));
                doc.Root.Element(element).Element(subElement).Add(new XElement(key, value));
            }
            else
                doc.Root.Element(element).Element(subElement).SetElementValue(key, value);

            doc.Save(document);
        }
        //
        public static string Read(string document, string element, string key)
        {
            string result = string.Empty;
            if (File.Exists(document))
            {
                try
                {
                    XDocument doc = XDocument.Load(document);
                    var value = doc.Descendants(element).Select(c => new { result = c.Element(key).Value }).FirstOrDefault();
                    if (value != null) { result = value.result; }
                }
                catch (Exception)
                {
                    result = string.Empty;
                }
            }
            return result;
        }
        public static string Read(string document, string element, string subElement, string key)
        {
            string result = string.Empty;
            if (File.Exists(document))
            {
                try
                {
                    XDocument doc = XDocument.Load(document);
                    var value = doc.Descendants(element).Descendants(subElement).Select(c => new { result = c.Element(key).Value }).FirstOrDefault();
                    if (value != null) { result = value.result; }
                }
                catch (Exception)
                {
                    result = string.Empty;
                }
            }
            return result;
        }
    }
}
