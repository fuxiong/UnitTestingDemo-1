
using System.Collections.Generic;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.AppServices
{
    public class AccountService : IAccountService
    {
        public Account GetAccountDetails(string accountNumber)
        {
            var lastAccountScore = GetAccountScores(accountNumber);

            return AccountFactory.Create(accountNumber, lastAccountScore);
        }

        public List<LastAccountScore> GetAccountScores(string accountNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}
