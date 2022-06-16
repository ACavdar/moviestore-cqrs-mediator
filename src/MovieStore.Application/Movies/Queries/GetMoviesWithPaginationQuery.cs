using MediatR;
using MovieStore.Application.Common.Models;

namespace MovieStore.Application.Movies.Queries;

public record GetMoviesWithPaginationQuery : IRequest<PaginatedList<MovieDTO>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}
