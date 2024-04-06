using NArchitecture.Core.Application.Responses;

namespace Application.Features.Instructors.Commands.Update;

public class UpdatedInstructorResponse : IResponse
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public string CompanyName { get; set; }
}
