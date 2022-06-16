using MovieStore.Domain.Common;

namespace MovieStore.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}