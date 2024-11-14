using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class12a.Models
{
    public class Continent
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Country>? Countries { get; set; }
    }
}
