using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChrisGiftCapstone.Models
{
    public class Budget
    {
        [Key]
        public int Id { get; set; }
        public SpendingLimit Spending { get; set; }

    }
    public enum SpendingLimit
    {
        Twenty,
        Fifty,
        Hundred,
        HundredPlus,

    }
}
