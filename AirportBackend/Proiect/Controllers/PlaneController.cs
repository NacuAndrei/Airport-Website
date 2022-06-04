using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proiect.Entities;
using Proiect.Managers;
using Proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaneController : ControllerBase
    {
        private IPlanesManager manager;
        public PlaneController(IPlanesManager planesManager)
        {
            this.manager = planesManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetPlanes()
        {
            var planes = manager.GetPlanes();

            return Ok(planes);
        }

        [HttpGet("byId/{id}")]
        public async Task<IActionResult> GetPlaneById(string id)
        {
            var plane = manager.GetPlaneById(id);

            return Ok(plane);
        }

        [HttpGet("IncludePlaneAndTickets")]
        public async Task<IActionResult> GetPlanesWithTickets()
        {
            var planes = manager.GetPlanesWithTickets();

            return Ok(planes);
        }

        [HttpGet("JoinPlaneAndTickets")]
        public async Task<IActionResult> JoinPlanesTIckets()
        {
            var planes = manager.JoinPlanesTickets();
            return Ok(planes);
        }

        [HttpGet("OrderBy")]
        public async Task<IActionResult> OrderBy()
        {
            var average = manager.GetGroupBy();
            return Ok(average);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PlaneCreationModel planeCreationModel)
        {
            manager.Create(planeCreationModel);

            return Ok();
            
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] PlaneCreationModel planeCreationModel)
        {
            manager.Update(planeCreationModel);

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
