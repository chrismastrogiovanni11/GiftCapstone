﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChrisGiftCapstone.Models
{
    public class TypeOfRelationship
    {
        [Key]
        public int Id { get; set; }
        public string Relationship { get; set; }


    }
}