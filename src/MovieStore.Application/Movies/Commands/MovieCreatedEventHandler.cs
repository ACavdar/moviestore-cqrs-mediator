using MediatR;
using Microsoft.Extensions.Logging;
using MovieStore.Application.Common.Models;
using MovieStore.Domain.Movies;

namespace MovieStore.Application.Movies.Commands;

public class MovieCreatedEventHandler : INotificationHandler<DomainEventNotification<MovieCreatedEvent>>
{
    private readonly ILogger<MovieCreatedEventHandler> _logger;

    public MovieCreatedEventHandler(ILogger<MovieCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(DomainEventNotification<MovieCreatedEvent> notification, CancellationToken cancellationToken)
    {
        var domainEvent = notification.DomainEvent;

        _logger.LogInformation("MovieStore Domain Event: {DomainEvent}", domainEvent.GetType().Name);

        return Task.CompletedTask;
    }
}
