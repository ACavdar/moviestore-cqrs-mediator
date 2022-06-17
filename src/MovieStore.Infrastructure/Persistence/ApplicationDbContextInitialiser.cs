using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieStore.Domain.Movies;

namespace MovieStore.Infrastructure.Persistence;

public class ApplicationDbContextInitialiser
{
    private readonly ILogger<ApplicationDbContextInitialiser> _logger;

    private readonly ApplicationDbContext _context;

    public ApplicationDbContextInitialiser(ILogger<ApplicationDbContextInitialiser> logger
        , ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task InitialiseAsync()
    {
        try
        {
            if (_context.Database.IsSqlServer())
            {
                await _context.Database.MigrateAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while initialising the database.");
            throw;
        }
    }

    public async Task SeedAsync()
    {
        try
        {
            await TrySeedAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while seeding the database.");
            throw;
        }
    }

    public async Task TrySeedAsync()
    {
        // Default data
        // Seed, if necessary
        if (!_context.Movies.Any())
        {
            _context.Movies.Add(new Movie
            {
                Title = "Passengers",
                Price = 12.75m
            });

            _context.Movies.Add(new Movie
            {
                Title = "Star Wars: A New Hope",
                Price = 5.99m
            });

            _context.Movies.Add(new Movie
            {
                Title = "Lord of the Rings",
                Price = 7.99m
            });

            await _context.SaveChangesAsync();
        }
    }
}
