using AutoMapper;
using Glimpse.Mvc.AlternateType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test2.Dtos;
using Test2.Models;

namespace Test2.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRentalDto)
        {
            //if (newRentalDto.MovieIds.Count == 0)
            //{
            //    return BadRequest("No Movie ID's have been given.");
            //}

            var customer = _context.Customers.Single(c => c.Id == newRentalDto.CustomerId);

            //if(customer==null)
            //{
            //    return BadRequest("Customer's ID is invalid.");
            //}
           
            var movies = _context.Movies.Where(m => newRentalDto.MovieIds.Contains(m.Id)).ToList();

            //if(movies.Count!=newRentalDto.MovieIds.Count)
            //{
            //    return BadRequest("One or more movies ID are not valid");
            //}


            foreach(var movie in movies)
            {

                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available.");
                }
                movie.NumberAvailable--;


                {
                    var rental = new Rental
                    {
                        Customer = customer,
                        Movie = movie,
                        DateRented = DateTime.Now
                    };
                    _context.Rentals.Add(rental);
                }
            }
            _context.SaveChanges();

          return Ok();



        }
    }
}