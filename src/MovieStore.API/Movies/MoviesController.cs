using Microsoft.AspNetCore.Mvc;
using MovieStore.API.Controllers;
using MovieStore.Application.Common.Models;
using MovieStore.Application.Movies;
using MovieStore.Application.Movies.Commands;
using MovieStore.Application.Movies.Queries;

namespace MovieStore.API.Movies
{
    public class MoviesController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<PaginatedList<MovieDTO>>> GetMoviessWithPagination([FromQuery] GetMoviesWithPaginationQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateMovieCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
