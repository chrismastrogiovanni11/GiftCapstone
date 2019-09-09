using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChrisGiftCapstone.Models
{
    public class LengthOfRelationship
    {
        [Key]
        public int Id { get; set; }
        public TimeKnown Time { get; set; }

    }

    public enum TimeKnown
    {
        SixMonths,
        OneToThreeYears,
        FiveToEightYears,
        TenPlusYears,
        Lifetime,

    }
}
