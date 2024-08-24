using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelemetryPortal.Models;

namespace TelemetryPortal.Services
{
    public interface IClientService
    {
        Task AddClientAsync(Client entity);
        Task<IEnumerable<Client>> GetAllClientsAsync();
        Task<Client> GetClientByIdAsync(Guid? id);
        Task UpdateClientAsync(Client entity);
        Task RemoveClientAsync(Client entity);
    }
}
