using Domain.Cows;
using Domain.Enclosures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tasks;
public class Job
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }

    public int Length { get; set; }
    public int? RecurringTaskId { get; set; }
    public RecurringTask RecurringTask { get; set; }    
    public int? PenId { get; set; }
    public Pen Pen { get; set; }
    public int? CowId { get; set; }
    public Cow Cow { get; set; }

    public ICollection<WorkerJob> WorkerJobs { get; set; }

}
