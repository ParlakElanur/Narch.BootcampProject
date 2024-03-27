using Domain.Entities;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.Blacklists.Commands.Update;

public class UpdatedBlacklistResponse : IResponse
{
    public int Id { get; set; }
    public string Reason { get; set; }
    public DateTime Date { get; set; }
    public int ApplicantId { get; set; }
    public Applicant Applicant { get; set; }
}