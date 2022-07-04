using RefactoringTest.Models;

namespace RefactoringTest.Services
{
    public interface IClientService
    {
        List<Client> GetClients();
        Task<bool> AddClient(Client client);
    }
}
