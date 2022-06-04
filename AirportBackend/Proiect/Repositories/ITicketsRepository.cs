using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public interface ITicketsRepository
    {
        IQueryable<Ticket> GetTickets();    //gets all tickets
        IQueryable<string> GetTicketsIds(); //gets all ids from tickets
        /*IQueryable<Ticket> JoinTicketsRoutes(); //join Tickets and Routes*/
        void Create(Ticket ticket);
        void Update(Ticket ticket);
        void Delete(Ticket ticket);
    }
}
