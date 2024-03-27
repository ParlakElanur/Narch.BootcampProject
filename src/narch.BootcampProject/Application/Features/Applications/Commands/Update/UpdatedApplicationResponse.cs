using Domain.Entities;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.Applications.Commands.Update;

public class UpdatedApplicationResponse : IResponse
{
    public int Id { get; set; }
    public int ApplicantId { get; set; }
    public int BootcampId { get; set; }
    public int ApplicationStateId { get; set; }
    public Applicant Applicant { get; set; }
    public Bootcamp Bootcamp { get; set; }
    public ApplicationState ApplicationState { get; set; }
}