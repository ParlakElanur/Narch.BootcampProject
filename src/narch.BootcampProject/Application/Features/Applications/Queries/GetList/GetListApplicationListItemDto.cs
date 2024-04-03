using Domain.Entities;
using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Applications.Queries.GetList;

public class GetListApplicationListItemDto : IDto
{
    public int Id { get; set; }
    public Guid ApplicantId { get; set; }
    public int BootcampId { get; set; }
    public int ApplicationStateId { get; set; }
}
