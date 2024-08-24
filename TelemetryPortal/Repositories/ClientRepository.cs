using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelemetryPortal.Data;
using TelemetryPortal.Models;

namespace TelemetryPortal.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(TechtrendsContext context) : base(context)
        {
        }

        // Asynchronous method to get a client by ID
        public async Task<Client> GetClientByIdAsync(Guid? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return await GetByIdAsync(id.Value);
        }

        // Asynchronous method to get all clients
        public async Task<IEnumerable<Client>> GetAllClientsAsync()
        {
            return await GetAllAsync();
        }

        // Asynchronous method to add a client
        public async Task AddClientAsync(Client entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            await AddAsync(entity);
        }

        // Asynchronous method to update a client
        public async Task UpdateClientAsync(Client entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            await UpdateAsync(entity);
        }

        // Asynchronous method to remove a client
        public async Task RemoveClientAsync(Client entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            await RemoveAsync(entity);
        }
    }
}
