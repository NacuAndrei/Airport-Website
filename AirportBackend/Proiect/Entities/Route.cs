using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public class Route
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<PlaneRoute> PlaneRoutes { get; set; }
    }
}
