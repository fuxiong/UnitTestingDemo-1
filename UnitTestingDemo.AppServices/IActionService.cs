using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.AppServices
{
    public interface IActionService
    {
        List<AccountAction> GetAccountActions(XmlDocument response);
    }
}
