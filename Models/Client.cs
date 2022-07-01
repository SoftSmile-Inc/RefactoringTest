using System.ComponentModel.DataAnnotations;

namespace RefactoringTest.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool HasCreditLimit { get; set; }
        public int CreditLimit { get; set; }
    }
}
