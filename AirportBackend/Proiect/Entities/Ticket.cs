using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public class Ticket
    {
        public string Id { get; set; }
        public string Price { get; set; }
        public string DateOfPurchase { get; set; }
        public string PlaneId { get; set; }
        public string UserId { get; set; }
        public Plane Plane { get; set; }
        public User User { get; set; }
    }
}
