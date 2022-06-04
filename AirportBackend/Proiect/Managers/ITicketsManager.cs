using Proiect.Entities;
using Proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Managers
{
    public interface ITicketsManager
    {
        List<Ticket> GetTickets();      //gets all tickets
        List<string> GetTicketsIds();   //gets all ids from tickets
        Ticket GetTicketById(string id);    //gets a ticket with given id
        List<TicketIdAndPriceModel> PricesBelow(string value);         //gets all tickets(id and price) with a price below given value

        void Create(TicketCreationModel model);
        void Update(TicketCreationModel model);
        void Delete(string id);
    }
}
