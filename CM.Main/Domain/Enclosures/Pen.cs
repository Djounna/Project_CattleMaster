using Domain.Cows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enclosures;
public class Pen
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Area { get; set; }   
    public int Size { get; set; }

    public ICollection<Cow> Cows { get; set; } = new List<Cow>();


}
