using MediatR;
using MovieStore.Application.Common.Interfaces;
using MovieStore.Domain.Movies;

namespace MovieStore.Application.Movies.Commands;

public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateMovieCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
    {
        var entity = new Movie
        {
            Title = request.Title,
            Price = request.Price
        };

        entity.DomainEvents.Add(new MovieCreatedEvent(entity));

        _context.Movies.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}