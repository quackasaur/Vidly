using System;
using System.Collections.Generic;

namespace Vidly.Dtos
{
    public class RentalDto
    {
        public int Id { get; set; }
        public CustomerDto Customer{ get; set; }
        public MovieDto Movie{ get; set; }
        public DateTime DateRented { get; set; }
    }
}