using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountService _AcService;

        public AccountController(IAccountService AcService)
        {
            _AcService = AcService;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AccountEntity account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var resultAccount = await _AcService.Post(account);
                if (resultAccount != null)
                {
                    return Created(new Uri(Url.Link("GetWithId", new { id = resultAccount.Id })), resultAccount);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
