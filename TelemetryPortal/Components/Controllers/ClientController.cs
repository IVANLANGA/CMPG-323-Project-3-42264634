using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TelemetryPortal.Models;
using TelemetryPortal.Services;

namespace TelemetryPortal.Controllers
{
    public class ClientController : Controller
    {
        private readonly ClientService _clientService;

        public ClientController(ClientService clientService)
        {
            _clientService = clientService;
        }

        public async Task<IActionResult> Index()
        {
            var clients = await _clientService.GetAllClientsAsync();
            return View(clients);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var client = await _clientService.GetClientByIdAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Client client)
        {
            if (ModelState.IsValid)
            {
                await _clientService.AddClientAsync(client);
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var client = await _clientService.GetClientByIdAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Client client)
        {
            if (id != client.ClientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _clientService.UpdateClientAsync(client);
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var client = await _clientService.GetClientByIdAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Client client)
        {
            await _clientService.RemoveClientAsync(client);
            return RedirectToAction(nameof(Index));
        }
    }
}
