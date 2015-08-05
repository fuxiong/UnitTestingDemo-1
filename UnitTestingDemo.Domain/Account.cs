
using System;
using System.Collections.Generic;

namespace UnitTestingDemo.Domain
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string Country { get; set; }
        public DateTime? LastLetterDate { get; set; }
        public int? NoOfChaseLettersAtCurrentPostcode { get; set; }
        public int? NoOfChaseLettersAtTracedPostcode { get; set; }
        public DateTime? RecourseEndDate { get; set; }
        public AccountScore AccountScore { get; set; }
        public List<AccountAction> AccountActions { get; set; }
    }
}
