using RefactoringTest.Models;

namespace RefactoringTest.Repositories
{
    public interface IClientRepository
    {
        List<Client> GetClients();
        Task AddClient(Client client);
    }
}
