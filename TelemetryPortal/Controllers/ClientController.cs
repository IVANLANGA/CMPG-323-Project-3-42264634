using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelemetryPortal.Models;
using TelemetryPortal.Services;

namespace TelemetryPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        // GET: api/client
        [HttpGet]
        public ActionResult<IEnumerable<Client>> GetAllClients()
        {
            var clients = _clientService.GetAllClients();
            return Ok(clients);
        }

        // GET: api/client/{id}
        [HttpGet("{id}")]
        public ActionResult<Client> GetClientById(Guid id)
        {
            var client = _clientService.GetClientById(id);
            if (client == null)
            {
                return NotFound();
            }
            return Ok(client);
        }

        // POST: api/client
        [HttpPost]
        public ActionResult<Client> AddClient(Client client)
        {
            if (client == null)
            {
                return BadRequest("Client cannot be null");
            }

            _clientService.AddClient(client);
            return CreatedAtAction(nameof(GetClientById), new { id = client.ClientId }, client);
        }

        // PUT: api/client/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateClient(Guid id, Client client)
        {
            if (id != client.ClientId)
            {
                return BadRequest("Client ID mismatch");
            }

            var existingClient = _clientService.GetClientById(id);
            if (existingClient == null)
            {
                return NotFound();
            }

            _clientService.UpdateClient(client);
            return NoContent();
        }

        // DELETE: api/client/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteClient(Guid id)
        {
            var client = _clientService.GetClientById(id);
            if (client == null)
            {
                return NotFound();
            }

            _clientService.RemoveClient(client);
            return NoContent();
        }
    }
}
