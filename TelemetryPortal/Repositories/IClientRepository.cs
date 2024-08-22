using TelemetryPortal.Models;
using System.Threading.Tasks;
using TelemetryPortal.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TelemetryPortal.Repositories
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Client GetClientById(Guid? id);
        IEnumerable<Client> GetAllClients();
        void RemoveClient(Client entity);
        void UpdateClient(Client entity);
        void AddClient(Client entity);
    }
}
