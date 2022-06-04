using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public class Plane
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<PlaneRoute> PlaneRoutes { get; set; }
    }
}
