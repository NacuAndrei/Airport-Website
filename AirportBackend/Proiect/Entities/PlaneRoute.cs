using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public class PlaneRoute
    {
        public string PlaneId { get; set; }
        public Plane Plane { get; set; }
        public string RouteId { get; set; }
        public Route Route { get; set; }
    }
}
