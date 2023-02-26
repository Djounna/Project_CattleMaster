using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cows;
public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Cow> Cows { get;} = new List<Cow>();
}
