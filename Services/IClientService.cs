using RefactoringTest.Models;

namespace RefactoringTest.Services
{
    public interface IClientService
    {
        Task<List<Client>> GetClients();
        Task<bool> AddClient(Client client);
    }
}
