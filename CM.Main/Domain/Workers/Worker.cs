using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Workers;
public class Worker
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? AuthId { get; set; }
}
