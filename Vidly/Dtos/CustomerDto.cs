using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public int MembershipTypeId { get; set; }
        
        public MembershipTypeDto MembershipType { get; set; }
       // [Min18YearsIfAMember] because dto is used for data transfer
        public DateTime? Birthdate { get; set; }
    }
}