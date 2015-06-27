using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.AppServices
{
    public class AccountFactory
    {
        public static Account Create(string accountNumberr, List<LastAccountScore> accountScores)
        {
            var account = new Account();


            return account;
        }
    }
}
