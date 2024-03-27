using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Blacklist : Entity<int>
{
    public string Reason { get; set; }
    public DateTime Date { get; set; }
    public Guid ApplicantId { get; set; }

    public Blacklist()
    {
    }
    public Blacklist(int id, string reason, DateTime date, Guid applicantId) : this()
    {
        Id = id;
        Reason = reason;
        Date = date;
        ApplicantId = applicantId;
    }
    public virtual Applicant Applicant { get; set; }
}
