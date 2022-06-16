using FluentValidation;

namespace MovieStore.Application.Movies.Queries;

public class GetMoviesWithPaginationQueryValidator : AbstractValidator<GetMoviesWithPaginationQuery>
{
    public GetMoviesWithPaginationQueryValidator()
    {
        RuleFor(x => x.PageNumber)
            .GreaterThanOrEqualTo(1).WithMessage("PageNumber should be at least 1 or greater than 1.");

        RuleFor(x => x.PageSize)
            .GreaterThanOrEqualTo(1).WithMessage("PageSize should be at least 1 or greater than 1.");
    }
}
