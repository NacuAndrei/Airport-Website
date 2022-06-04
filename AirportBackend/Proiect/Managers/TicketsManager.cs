using Proiect.Entities;
using Proiect.Models;
using Proiect.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Managers
{
    public class TicketsManager : ITicketsManager
    {
        private readonly ITicketsRepository ticketsRepository;

        public TicketsManager(ITicketsRepository ticketsRepository)
        {
            this.ticketsRepository = ticketsRepository;
        }

        public void Create(TicketCreationModel model)
        {
            var newTicket = new Ticket
            {
                Id = model.Id,
                Price = model.Price,
                DateOfPurchase = model.DateOfPurchase,
                PlaneId = model.PlaneId

            };

            ticketsRepository.Create(newTicket);
        }

        public void Update(TicketCreationModel model)
        {
            var ticket = GetTicketById(model.Id);

            ticket.Id = model.Id;
            ticket.Price = model.Price;
            ticket.DateOfPurchase = model.DateOfPurchase;
            ticket.PlaneId = model.PlaneId;

            ticketsRepository.Update(ticket);
        }

        public void Delete(string id)
        {
            var ticket = GetTicketById(id);

            ticketsRepository.Delete(ticket);
        }

        public Ticket GetTicketById(string id)
        {
            var ticket = ticketsRepository.GetTickets()
                .FirstOrDefault(x => x.Id == id);

            return ticket;
        }

        public List<Ticket> GetTickets()
        {
            return ticketsRepository.GetTickets().ToList();
        }

        public List<string> GetTicketsIds()
        {
            var tickets = ticketsRepository.GetTickets();
            var idList = tickets.Select(x => x.Id)
                .ToList();

            return idList;
        }

        public List<TicketIdAndPriceModel> PricesBelow(string value)
        {
            var tickets = ticketsRepository.GetTickets();
            var ticketsPricesBelow = tickets
                .Where(x => String.Compare(x.Price, value) < 0)
                .Where(x => string.IsNullOrEmpty(x.DateOfPurchase))
                .Select(x => new TicketIdAndPriceModel { Id = x.Id, Price = x.Price});             

            return ticketsPricesBelow.ToList();
        }

        
    }
}
