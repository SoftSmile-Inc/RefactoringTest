using RefactoringTest.Models;
using RefactoringTest.Repositories;

namespace RefactoringTest.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly ClientCreditService _clientCreditService;

        public ClientService(IClientRepository clientRepository, ClientCreditService clientCreditService)
        {
            _clientRepository = clientRepository;
            _clientCreditService = clientCreditService;
        }

        public async Task<bool> AddClient(Client client)
        {

            if (string.IsNullOrEmpty(client.Name) || string.IsNullOrEmpty(client.LastName))
            {
                return false;
            }
            if (!client.Email.Contains("@") && !client.Email.Contains("."))
            {
                return false;
            }


            if (client.Name == "VeryImportantClient")
            {
                client.HasCreditLimit = false;
                client.CreditLimit = default;
            }
            else if(client.Name=="ImportantClient")
            {
                client.HasCreditLimit = true;
                client.CreditLimit = await _clientCreditService.GetCreditLimit(client) * 2;
            }
            else
            {
                client.HasCreditLimit = true;
                client.CreditLimit = await _clientCreditService.GetCreditLimit(client) ;
            }


            await _clientRepository.AddClient(client);

            return true;
        }

        public Task<List<Client>> GetClients()
        {
            return _clientRepository.GetClients();
        }
    }
}
