using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect.Entities;
using Proiect.Managers;
using Proiect.Models;
using Proiect.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private ITicketsManager manager;
        public TicketController(ITicketsManager ticketsManager)
        {
            this.manager = ticketsManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetTickets()
        {
            var tickets = manager.GetTickets();

            return Ok(tickets);
        }

        [HttpGet("PricesBelow")]
        [Authorize(Policy = "BasicUser")]
        public async Task<IActionResult> PricesBelow(string value)
        {
            var ticketsPrices = manager.PricesBelow(value);

            return Ok(ticketsPrices);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TicketCreationModel ticketCreationModel)
        {
            manager.Create(ticketCreationModel);

            return Ok();
        }

        [HttpPut]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> Update([FromBody] TicketCreationModel ticketCreationModel)
        {
            manager.Update(ticketCreationModel);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            manager.Delete(id);

            return Ok();
        }
    }
}
