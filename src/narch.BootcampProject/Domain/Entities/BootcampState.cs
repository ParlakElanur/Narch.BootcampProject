using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class BootcampState : Entity<int>
{
    public string Name { get; set; }

    public BootcampState()
    {
        Bootcamps = new HashSet<Bootcamp>();
    }
    public BootcampState(int id, string name) : this()
    {
        Id = id;
        Name = name;
    }
    public virtual ICollection<Bootcamp> Bootcamps { get; set; }
}
