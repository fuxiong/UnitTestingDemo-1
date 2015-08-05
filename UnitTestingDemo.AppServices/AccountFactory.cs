using System.Collections.Generic;
using System.Linq;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.AppServices
{
    public class AccountFactory
    {
        public static Account Create(string accountNumber, AccountWarehouse accountWarehouse, AccountLetter accountLetter, 
            AccountLetterTrace accountLetterTrace, AccountClients accountClients)
        {
            var account = new Account
            {
                AccountNumber = accountNumber,
                Country = accountWarehouse.Country,
                LastLetterDate = accountLetter.LastLetterDate,
                NoOfChaseLettersAtCurrentPostcode = accountLetter.NoOfChaseLetters,
                NoOfChaseLettersAtTracedPostcode = accountLetterTrace.NoOfChaseLetters,
                RecourseEndDate = accountClients.Portfolio1.RecourseEndDate
            };

            return account;
        }

        public static List<Account> Create(List<AccountWarehouse> accountWarehouses, List<AccountLetter> accountLetters, 
            List<AccountLetterTrace> accountLettersTraces, List<AccountClients> accountClients)
        {
            return (from accountWarehouse in accountWarehouses 
                    let accountNumber = accountWarehouse.AccountNumber 
                    let accountLetter = accountLetters.FirstOrDefault(a => a.AccountNumber == accountNumber) 
                    let accountLetterTrace = accountLettersTraces.FirstOrDefault(a => a.AccountNumber == accountNumber) 
                    let accClients = accountClients.FirstOrDefault(a => a.AccountNumber == accountNumber) 
                    select Create(accountNumber, accountWarehouse, accountLetter, accountLetterTrace, accClients)).ToList();
        }
    }
}
