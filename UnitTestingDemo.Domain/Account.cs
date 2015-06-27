
using System.Collections.Generic;

namespace UnitTestingDemo.Domain
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public AccountScore AccountScore { get; set; }
        public List<AccountAction> AccountActions { get; set; }
    }
}
