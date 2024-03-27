using FluentValidation;

namespace Application.Features.Applications.Commands.Create;

public class CreateApplicationCommandValidator : AbstractValidator<CreateApplicationCommand>
{
    public CreateApplicationCommandValidator()
    {
        RuleFor(c => c.ApplicantId).NotEmpty();
        RuleFor(c => c.BootcampId).NotEmpty();
        RuleFor(c => c.ApplicationStateId).NotEmpty();
        RuleFor(c => c.Applicant).NotEmpty();
        RuleFor(c => c.Bootcamp).NotEmpty();
        RuleFor(c => c.ApplicationState).NotEmpty();
    }
}