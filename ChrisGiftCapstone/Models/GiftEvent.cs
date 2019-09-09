using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChrisGiftCapstone.Models
{
    public class GiftEvent
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Event Name")]
        public string EventName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Event Date")]
        public DateTime EventDate { get; set; }

    }
    
}