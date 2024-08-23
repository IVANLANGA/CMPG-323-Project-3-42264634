using TelemetryPortal.Models;
using System;
using System.Collections.Generic;

namespace TelemetryPortal.Services
{
    public interface IClientService
    {
        Client GetClientById(Guid? id);
        IEnumerable<Client> GetAllClients();
        void RemoveClient(Client entity);
        void UpdateClient(Client entity);
        void AddClient(Client entity);
    }

}