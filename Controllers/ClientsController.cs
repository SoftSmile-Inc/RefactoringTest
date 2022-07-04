using Microsoft.AspNetCore.Mvc;
using RefactoringTest.Models;
using RefactoringTest.Services;

namespace RefactoringTest.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ClientsController : Controller
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public ActionResult<List<Client>> Get()
        {
            return _clientService.GetClients();
        }


        // POST: Clients/Create
        [HttpPost]
        public async Task<IActionResult> Add(Client client)
        {
            if (await _clientService.AddClient(client))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
