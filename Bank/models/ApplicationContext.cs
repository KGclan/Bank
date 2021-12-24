using Microsoft.EntityFrameworkCore;
using Bank.models;

namespace Bank
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<TypeAccount> TypeAccounts { get; set; }
        public DbSet<Aggrement> Aggrements { get; set; }
        public DbSet<Banks> Banks { get; set; }
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; " +
            "Database=persondb; Trusted_Connection=True;");
        }
    }
}
