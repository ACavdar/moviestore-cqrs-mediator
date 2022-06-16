using Microsoft.EntityFrameworkCore;
using MovieStore.Domain.Movies;

namespace MovieStore.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Movie> Movies { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
