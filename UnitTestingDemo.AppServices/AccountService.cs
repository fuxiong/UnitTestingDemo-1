
using System.Collections.Generic;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.AppServices
{
    public class AccountService : IAccountService
    {
        public List<Account> GetAccountDetails(string accountNumber)
        {
            var accountWarehouses = GetAccountWarehouseData(accountNumber);
            var accountLetters = GetAccountLetterData(accountNumber);
            var accountLettersTraces = GetAccountLetterTraceData(accountNumber);
            var accountClients = GetAccountClientsData(accountNumber);

            return AccountFactory.Create(accountWarehouses, accountLetters, accountLettersTraces, accountClients);
        }

        public List<AccountWarehouse> GetAccountWarehouseData(string accountNumber)
        {
            throw new System.NotImplementedException();
        }

        public List<AccountLetter> GetAccountLetterData(string accountNumber)
        {
            throw new System.NotImplementedException();
        }

        public List<AccountLetterTrace> GetAccountLetterTraceData(string accountNumber)
        {
            throw new System.NotImplementedException();
        }

        public List<AccountClients> GetAccountClientsData(string accountNumber)
        {
            throw new System.NotImplementedException();
        }

        public List<LastAccountScore> GetAccountScores(string accountNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}
