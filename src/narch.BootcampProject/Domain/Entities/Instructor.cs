using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Instructor : User
{
    public string CompanyName { get; set; }
    public Instructor()
    {
        Bootcamps = new HashSet<Bootcamp>();
    }
    public Instructor(string companyName) : this()
    {
        CompanyName = companyName;
    }
    public virtual ICollection<Bootcamp> Bootcamps { get; set; }
}
