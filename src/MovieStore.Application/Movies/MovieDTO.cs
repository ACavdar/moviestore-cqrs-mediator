using MovieStore.Application.Common.Mappings;
using MovieStore.Domain.Movies;

namespace MovieStore.Application.Movies;

public class MovieDTO : IMapFrom<Movie>
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public decimal? Price { get; set; }
}
