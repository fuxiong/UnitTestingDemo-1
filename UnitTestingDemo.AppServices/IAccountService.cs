
using System.Collections.Generic;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.AppServices
{
    interface IAccountService
    {
        List<Account> GetAccountDetails(string accountNumber);
        List<AccountWarehouse> GetAccountWarehouseData(string accountNumber);
        List<AccountLetter> GetAccountLetterData(string accountNumber);
        List<AccountLetterTrace> GetAccountLetterTraceData(string accountNumber);
        List<AccountClients> GetAccountClientsData(string accountNumber);
        List<LastAccountScore> GetAccountScores(string accountNumber);
    }
}
