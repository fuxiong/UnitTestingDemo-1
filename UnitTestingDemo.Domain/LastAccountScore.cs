using System;
using System.ComponentModel.DataAnnotations;

namespace UnitTestingDemo.Domain
{
    public class LastAccountScore
    {
        [Key]
        public string AccountNumber { get; set; }
        public DateTime? LastAbilityToPayDate { get; set; }
        public string LastAbilityToPayScorecard { get; set; }
        public int? LastAbilityToPayScore { get; set; }
        public DateTime? LastEnforcementDate { get; set; }
        public string LastEnforcementScorecard { get; set; }
        public int? LastEnforcementScore { get; set; }
        public string LastRightTimeToDialSegment { get; set; }
        public DateTime? DateOfScoring { get; set; }
        public string Segment { get; set; }
        public int? Score { get; set; }
    }
}
