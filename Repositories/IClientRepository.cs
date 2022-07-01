using RefactoringTest.Models;

namespace RefactoringTest.Repositories
{
    public interface IClientRepository
    {
        Task<List<Client>> GetClients();
        Task AddClient(Client client);
    }
}
