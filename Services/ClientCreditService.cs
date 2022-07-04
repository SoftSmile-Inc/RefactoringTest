using RefactoringTest.Models;

namespace RefactoringTest.Services
{
    public class ClientCreditService
    {
        public Task<int> GetCreditLimit(Client client)
        {
            if (client.Age < 21)
            {
                return Task.FromResult(10);
            }
            else if (client.Age < 35)
            {
                return Task.FromResult(20);
            }
            else if (client.Age < 65)
            {
                return Task.FromResult(30);
            }
            else
            {
                return Task.FromResult(5);
            }
        }
    }
}
