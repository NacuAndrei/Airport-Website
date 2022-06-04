using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public class TicketCreationModel
    {
        public string Id { get; set; }
        public string Price { get; set; }
        public string DateOfPurchase { get; set; }
        public string PlaneId { get; set; }
    }
}
