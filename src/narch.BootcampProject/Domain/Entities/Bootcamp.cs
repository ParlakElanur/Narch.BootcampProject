using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class Bootcamp : Entity<int>
{
    public string Name { get; set; }
    public Guid InstructorId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int BootcampStateId { get; set; }

    public Bootcamp()
    {
        Applications = new HashSet<Application>();
    }

    public Bootcamp(int id, string name, Guid ınstructorId, DateTime startDate, DateTime endDate, int bootcampStateId)
        : this()
    {
        Id = id;
        Name = name;
        InstructorId = ınstructorId;
        StartDate = startDate;
        EndDate = endDate;
        BootcampStateId = bootcampStateId;
    }

    public virtual ICollection<Application> Applications { get; set; }
    public virtual Instructor Instructor { get; set; }
    public virtual BootcampState BootcampState { get; set; }
}
