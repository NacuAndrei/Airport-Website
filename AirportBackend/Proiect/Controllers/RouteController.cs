using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class RouteController : ControllerBase
    {
        private IRoutesManager manager;
        public RouteController(IRoutesManager routesManager)
        {
            this.manager = routesManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetRoutes()
        {
            var routes = manager.GetRoutes();

            return Ok(routes);
        }

        [HttpGet("AlphabeticalOrder")]
        public async Task<IActionResult> AlphabeticalOrder()
        {
            var routesNames = manager.AlphabeticalOrder();

            return Ok(routesNames);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RouteCreationModel routeCreationModel)
        {
            manager.Create(routeCreationModel);

            return Ok();

        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] RouteCreationModel routeCreationModel)
        {
            manager.Update(routeCreationModel);

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
