using Domain.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tasks;
public class WorkerJob
{
    public int Id { get; set; }
    public int WorkerId { get; set; }
    public int JobId { get; set; }

    public Worker Worker { get; set; }
    public Job Job { get; set; }
}
