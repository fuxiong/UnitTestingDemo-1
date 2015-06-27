using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.AppServices
{
    public class ActionService : IActionService
    {
        public List<AccountAction> GetAccountActions(XmlDocument response)
        {
            var data = XmlConversion.ToXDocument(response);

            var accountActions = data.Descendants("actions1")
                .Elements()
                .Select(x => new AccountAction
                {
                    Action = x.Element("action") != null ? x.Element("action").Value : null,
                    SendToLima = Convert.ToBoolean(x.Element("sendToLima").Value)
                })
                .ToList();

            return accountActions;
        }
    }
}
