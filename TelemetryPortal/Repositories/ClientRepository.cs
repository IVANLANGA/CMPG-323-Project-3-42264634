using Microsoft.EntityFrameworkCore;
using TelemetryPortal.Data;
using TelemetryPortal.Models;

namespace TelemetryPortal.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(TechtrendsContext context) : base(context)
        {
        }

        public Client GetClientById(Guid? id)
        {
            return GetAll().FirstOrDefault(x => x.ClientId == id);
        }

        public IEnumerable<Client> GetAllClients()
        {
            return GetAll().ToList();
        }

        public void RemoveClient(Client entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateClient(Client entity)
        {
            Update(entity);
        }

        public void AddClient(Client entity)
        {
            Add(entity);
        }
    }
}
