using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]

        public String Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }

        [Display(Name ="Date of birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public static readonly int Unknown = 0;
        public static readonly int PayAsYouGo = 1;
    }
}