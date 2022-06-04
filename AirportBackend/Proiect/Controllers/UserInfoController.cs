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
    public class UserInfoController : ControllerBase
    {
        private IUserInfosManager manager;
        public UserInfoController(IUserInfosManager userInfosManager)
        {
            this.manager = userInfosManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserInfos()
        {
            var userInfos = manager.GetUserInfos();

            return Ok(userInfos);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserInfoCreationModel userInfoCreationModel)
        {
            manager.Create(userInfoCreationModel);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UserInfoCreationModel userInfoCreationModel)
        {
            manager.Update(userInfoCreationModel);

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
