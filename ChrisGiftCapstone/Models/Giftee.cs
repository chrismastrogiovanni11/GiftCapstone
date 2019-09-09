using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChrisGiftCapstone.Models
{
    public class Giftee
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [ForeignKey("TypeOfRelationship")]
        [Display (Name = "Type of Relationship")]
        public int TypeOfRelationshipId { get; set; }
        public TypeOfRelationship TypeOfRelationship { get; set; }
        public IEnumerable<TypeOfRelationship> Relationships { get; set; }

        [ForeignKey ("LengthOfRelationship")]
        [Display (Name = "Length of Relationship")]
        public int LengthOfRelationshipId { get; set; }
        public LengthOfRelationship LengthOfRelationship { get; set; }
        public IEnumerable<LengthOfRelationship> LengthOfs { get; set; }

        [ForeignKey("Category")]
        [Display (Name ="Interests")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }


        [ForeignKey("Subcategory")]
        [Display(Name = "Interests")]
        public int SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; }
        public IEnumerable<Subcategory> Subcategories { get; set; }

    }
    
}