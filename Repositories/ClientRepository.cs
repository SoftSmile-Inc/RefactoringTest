using RefactoringTest.Models;

namespace RefactoringTest.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _appDbContext;

        public ClientRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddClient(Client client)
        {
            await _appDbContext.AddAsync(client);
            await _appDbContext.SaveChangesAsync();
        }

        public List<Client> GetClients()
        {
            return _appDbContext.Clients.ToList();
        }
    }
}
