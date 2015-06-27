
using System.Collections.Generic;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.AppServices
{
    interface IAccountService
    {
        Account GetAccountDetails(string accountNumber);
        List<LastAccountScore> GetAccountScores(string accountNumber);
    }
}
