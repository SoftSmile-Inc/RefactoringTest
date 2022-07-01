using RefactoringTest.Models;

namespace RefactoringTest.Services
{
    public class ClientCreditService
    {

        public async Task<int> GetCreditLimit(Client client)
        {
            if (client.Age < 21)
            {
                return 10;
            }
            else if (client.Age < 35) return 20;
            else if (client.Age < 65) return 30;
            else return 5;
        }
    }
}
