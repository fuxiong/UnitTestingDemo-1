﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace UnitTestingDemo.Domain
{
    public class XmlConversion
    {
        public static XmlDocument ToXmlDocument(XDocument xdoc)
        {
            var xmlDocument = new XmlDocument();
            using (var reader = xdoc.CreateReader())
            {
                xmlDocument.Load(reader);
            }
            return xmlDocument;
        }

        public static XDocument ToXDocument(XmlDocument xmlDoc)
        {
            using (var reader = new XmlNodeReader(xmlDoc))
            {
                reader.MoveToContent();
                return XDocument.Load(reader);
            }
        }
    }
}
