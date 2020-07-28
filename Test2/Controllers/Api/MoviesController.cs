using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test2.Dtos;
using Test2.Models;
using System.Data.Entity;

namespace Test2.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET ALL MOVIES
        //GET api/movies
        public IEnumerable<MovieDto> GetMovies()
        {
            return _context.Movies
                .Include(g=>g.Genre)
                .ToList()                
                .Select(Mapper.Map<Movie, MovieDto>);
        }




        //add movie
        //POST /api/movies
        [Authorize(Roles = RoleName.CanManageMovies)]
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                //throw new HttpResponseException(HttpStatusCode.BadRequest);
                return BadRequest();

            //mapowanie parametru movieDto na obiekt typu Movie
            var movie = Mapper.Map<MovieDto, Movie>(movieDto);

            //dodanie zmapowanego movie
            _context.Movies.Add(movie);

            _context.SaveChanges();

            //dodanie ID do zwróconego dto
            movieDto.Id = movie.Id;

            //zwrócenie uri i obiektu movieDto
            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

 

        //GET SINGLE MOVIE BY ID
        //show one movie
        //GET api/movies/1
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();
            }

            //zwraca OK result i wyswietlony film
            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }



        //update
        //PUT /api/movies/1
        [HttpPut]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public void UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);


            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(movieDto, movieInDb);

            _context.SaveChanges();
        }



        //DELETE /api/movies/1
        [HttpDelete]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public void DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();
        }

    }
}
