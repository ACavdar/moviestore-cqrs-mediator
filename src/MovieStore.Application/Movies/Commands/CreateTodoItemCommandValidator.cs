using FluentValidation;

namespace MovieStore.Application.Movies.Commands;

public class CreateTodoItemCommandValidator : AbstractValidator<CreateMovieCommand>
{
    public CreateTodoItemCommandValidator()
    {
        RuleFor(v => v.Title)
            .MaximumLength(200)
            .NotEmpty();
    }
}
