using Domain.Enclosures;
using Domain.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cows;

public class Cow
{
    public int Id { get; set; }
    public string Identifier { get; set; }
    public string Name { get; set; }

    public DateOnly BirthDate { get; set; }
    public string Race { get; set; }
    public string Status { get; set; }
    public bool Sex { get; set; }

    public int? PenId { get; set; }
    public Pen Pen { get; set; }
    public int? TemporaryPenId { get; set; }
    public Pen TemporaryPen { get; set; }

    public int? GroupId { get; set; }
    public Group Group { get; set;  }

    public ICollection<Job> Jobs { get; } = new List<Job>();

    

}
