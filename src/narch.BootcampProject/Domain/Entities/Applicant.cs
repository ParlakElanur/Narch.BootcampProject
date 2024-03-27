using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Applicant : User
{
    public string About { get; set; }
    public Applicant()
    {
        Applications = new HashSet<Application>();
    }
    public Applicant(string about) : this()
    {
        About = about;
    }
    public virtual ICollection<Application> Applications { get; set; }
    public virtual Blacklist Blacklist { get; set; }
}
