using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class ApplicationState : Entity<int>
{
    public string Name { get; set; }

    public ApplicationState()
    {
        Applications = new HashSet<Application>();
    }

    public ApplicationState(int id, string name)
        : this()
    {
        Id = id;
        Name = name;
    }

    public virtual ICollection<Application> Applications { get; set; }
}
