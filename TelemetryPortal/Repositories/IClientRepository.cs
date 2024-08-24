using TelemetryPortal.Models;
using System.Threading.Tasks;
using TelemetryPortal.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TelemetryPortal.Repositories
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Task<Client> GetClientByIdAsync(Guid? id);
        Task<IEnumerable<Client>> GetAllClientsAsync();
        Task AddClientAsync(Client entity);
        Task UpdateClientAsync(Client entity);
        Task RemoveClientAsync(Client entity);
    }
}
