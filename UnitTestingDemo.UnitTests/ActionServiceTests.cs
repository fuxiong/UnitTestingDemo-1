using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestingDemo.AppServices;

namespace UnitTestingDemo.UnitTests
{
    [TestClass]
    public class ActionServiceTests
    {
        private IActionService _actionService;
        private ActionServiceTestData _actionServiceTestData;

        [TestInitialize]
        public void Init()
        {
            _actionService = new ActionService();
            _actionServiceTestData = new ActionServiceTestData();
        }

        [TestMethod]
        public void ActionsAreCorrectlyReadFromDecisions()
        {
            var expectedActions = _actionServiceTestData.UnitTestActions();
            var actualActions = _actionService.GetAccountActions(_actionServiceTestData.UnitTestResponse());

            Assert.AreEqual(expectedActions.Count, actualActions.Count);
        }
    }
}
