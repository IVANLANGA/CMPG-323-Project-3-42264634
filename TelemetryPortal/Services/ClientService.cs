using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelemetryPortal.Models;
using TelemetryPortal.Repositories;

namespace TelemetryPortal.Services
{
    // Service class that provides business logic for managing Client entities
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        // Asynchronously adds a new Client entity to the repository
        public async Task AddClientAsync(Client entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            await _clientRepository.AddClientAsync(entity);
        }

        // Asynchronously retrieves all Client entities from the repository
        public async Task<IEnumerable<Client>> GetAllClientsAsync()
        {
            return await _clientRepository.GetAllClientsAsync();
        }

        // Asynchronously retrieves a Client entity by its ID from the repository
        public async Task<Client> GetClientByIdAsync(Guid? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return await _clientRepository.GetClientByIdAsync(id);
        }

        // Asynchronously updates an existing Client entity in the repository
        public async Task UpdateClientAsync(Client entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            await _clientRepository.UpdateClientAsync(entity);
        }

        // Asynchronously removes a Client entity from the repository
        public async Task RemoveClientAsync(Client entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            await _clientRepository.RemoveClientAsync(entity);
        }
    }
}
