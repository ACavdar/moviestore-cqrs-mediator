namespace MovieStore.Domain.Movies;

public class MovieCreatedEvent : DomainEvent
{
    public Movie Item { get; }

    public MovieCreatedEvent(Movie item)
    {
        Item = item;
    }
}