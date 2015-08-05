using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestingDemo.Domain
{
    public class AccountLetterTrace
    {
        public string AccountNumber { get; set; }
        public DateTime? LastLetterDate { get; set; }
        public int? NoOfChaseLetters { get; set; }
    }
}
