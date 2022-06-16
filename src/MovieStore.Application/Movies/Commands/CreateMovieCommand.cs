using MediatR;

namespace MovieStore.Application.Movies.Commands;

public record CreateMovieCommand : IRequest<int>
{
    public string? Title { get; init; }
    public decimal? Price { get; init; }
}
