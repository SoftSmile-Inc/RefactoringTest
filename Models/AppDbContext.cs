using Microsoft.EntityFrameworkCore;

namespace RefactoringTest.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("test");
            }
        }
    }
}
