using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Application : Entity<Guid>
{
    public Guid ApplicantId { get; set; }
    public int BootcampId { get; set; }
    public int ApplicationStateId { get; set; }
    public Application()
    {
    }
    public Application(Guid applicantId, int bootcampId, int applicationStateId) : this()
    {
        ApplicantId = applicantId;
        BootcampId = bootcampId;
        ApplicationStateId = applicationStateId;
    }
    public virtual Applicant Applicant { get; set; }
    public virtual Bootcamp Bootcamp { get; set; }
    public virtual ApplicationState ApplicationState { get; set; }
}
