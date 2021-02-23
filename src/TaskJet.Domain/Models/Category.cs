using System.Collections.Generic;
using TaskJet.Domain.Models;

namespace TaskJet.Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }

        /* EF Relations */
        public IEnumerable<Activity> Activities { get; set; }
    }
}
