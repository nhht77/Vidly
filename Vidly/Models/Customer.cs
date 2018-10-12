﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        [Display(Name = "Date Of Birth")]
        [Min18YearsIfAMember]
        public DateTime? DateOfBirth { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "MemberShip Type")]
        public byte MembershipTypeId { get; set; }
    }
}