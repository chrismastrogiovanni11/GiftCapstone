using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChrisGiftCapstone.Models
{
    public class GiftGetter
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Hobbies/Interests")]
        public string HobbiesInterest { get; set; }

        [ForeignKey("Giftee")]
        public int GifteeId { get; set; }
        public Giftee Giftee { get; set; }
        public IEnumerable<Giftee>Giftees{ get; set; }


        [ForeignKey("GiftEvent")]
        public int GiftEventId { get; set; }
        public GiftEvent GiftEvent { get; set; }
        public IEnumerable<GiftEvent> GiftEvents { get; set; }


        [ForeignKey("Budget")]
        public int BudgetId { get; set; }
        public Budget Budget { get; set; }
        public IEnumerable<Budget> Budgets { get; set; }

    }
    
}