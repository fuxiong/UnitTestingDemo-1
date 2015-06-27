using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.UnitTests
{
    public class ActionServiceTestData
    {
        public XmlDocument UnitTestResponse()
        {
            XNamespace soapNamespace = "http://www.w3.org/2001/12/soap-envelope";
            XNamespace ns = "http://lowell.co.uk";
            var response =
                new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement(soapNamespace + "Envelop", new XAttribute(XNamespace.Xmlns + "S", soapNamespace.NamespaceName),
                        new XElement(soapNamespace + "Body",
                            new XElement(ns + "fnPointResponse", new XAttribute(XNamespace.Xmlns + "ns", ns.NamespaceName),
                                new XElement("return",
                                    new XElement("invocation",
                                        new XElement("invocationDate")),
                                    new XElement("data",
                                        new XElement("account"),
                                        new XElement("customer")),
                                    new XElement("decision",
                                        new XElement("account"),
                                        new XElement("customer"),
                                        new XElement("actions", 
                                            new XElement("accountAction", 
                                                new XElement("action", "Repcode Move"),
                                                new XElement("sendToLima", false)),
                                            new XElement("accountAction",
                                                new XElement("action", "Send Letter"),
                                                new XElement("sendToLima", true)))))))));

            return XmlConversion.ToXmlDocument(response);
        }

        public List<AccountAction> UnitTestActions()
        {
            var actions = new List<AccountAction>
            {
                new AccountAction
                {
                    Action = "Repcode Move",
                    SendToLima = false
                },
                new AccountAction
                {
                    Action = "Send Letter",
                    SendToLima = true
                }
            };

            return actions;
        }
    }
}
