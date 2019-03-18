using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        public ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }

        // HttpGet /Api/NewRentals/
        public IEnumerable<RentalDto> GetRentals()
        {
            return _context.Rentals.Include(r => r.Customer).Include(r => r.Movie).ToList().Select(Mapper.Map<Rental, RentalDto>);
        }

        //DELETE /api/newrentals/id
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var rentalInDb = _context.Rentals.Include(r=>r.Movie).SingleOrDefault(r => r.Id == id);

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == rentalInDb.Movie.Id);

            movieInDb.NumberAvailable++;

            _context.Rentals.Remove(rentalInDb);

            _context.SaveChanges();

            return Ok();
        }
    }
}
