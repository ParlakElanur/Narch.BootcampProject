using FluentValidation;

namespace Application.Features.Applications.Commands.Update;

public class UpdateApplicationCommandValidator : AbstractValidator<UpdateApplicationCommand>
{
    public UpdateApplicationCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.ApplicantId).NotEmpty();
        RuleFor(c => c.BootcampId).NotEmpty();
        RuleFor(c => c.ApplicationStateId).NotEmpty();
        RuleFor(c => c.Applicant).NotEmpty();
        RuleFor(c => c.Bootcamp).NotEmpty();
        RuleFor(c => c.ApplicationState).NotEmpty();
    }
}