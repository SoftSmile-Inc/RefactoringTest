using System.ComponentModel.DataAnnotations;

namespace RefactoringTest.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Email { get; set; } = string.Empty;
        public bool HasCreditLimit { get; set; }
        public int CreditLimit { get; set; }
    }
}
