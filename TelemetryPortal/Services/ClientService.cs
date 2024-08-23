using System;
using System.Collections.Generic;
using System.Linq;
using TelemetryPortal.Models;
using TelemetryPortal.Repositories;

namespace TelemetryPortal.Services
{
    public class ClientService: IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository) 
        {
             _clientRepository = clientRepository;
        }

        public void AddClient(Client entity)
        {
            _clientRepository.Add(entity);
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _clientRepository.GetAll().ToList();
        }

        public Client GetClientById(Guid? id)
        {
            return _clientRepository.GetAll().FirstOrDefault(x => x.ClientId == id);
        }

        public void RemoveClient(Client entity)
        {
            _clientRepository.Remove(entity);
        }

        public void UpdateClient(Client entity)
        {
            _clientRepository.Update(entity);
        }
    }
}
