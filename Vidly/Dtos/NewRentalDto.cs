//this class is used for only adding the new rentals, for rest of the operations, there
//is a different class

using System;
using System.Collections.Generic;

namespace Vidly.Dtos
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
        public DateTime DateRented { get; set; }
    }
}