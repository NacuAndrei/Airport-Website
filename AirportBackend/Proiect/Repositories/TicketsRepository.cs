using Microsoft.EntityFrameworkCore;
using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public class TicketsRepository : ITicketsRepository
    {
        private readonly ProiectContext db;

        public TicketsRepository(ProiectContext db)
        {
            this.db = db;
        }

        public IQueryable<Ticket> GetTickets()
        {
            var tickets = db.Tickets;

            return tickets;
        }

        public IQueryable<string> GetTicketsIds()
        {
            var ticketsIds = db.Tickets
                .Select(x => x.Id);

            return ticketsIds;
        }

        /*public IQueryable<Ticket> JoinTicketsRoutes()
        {
           var ticketsJoin = 

            return ticketsJoin;
        }*/




        public void Create(Ticket ticket)
        {
            db.Tickets.Add(ticket);

            db.SaveChanges();
        }

        public void Update(Ticket ticket)
        {
            db.Tickets.Update(ticket);

            db.SaveChanges();
        }

        public void Delete(Ticket ticket)
        {
            db.Tickets.Remove(ticket);

            db.SaveChanges();
        }

    }
}
