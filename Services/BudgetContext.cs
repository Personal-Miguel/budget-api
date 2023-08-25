using Microsoft.EntityFrameworkCore;

namespace BudgetApi.Services
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }

        public virtual DbSet<MonetaryAccount> MonetaryAccounts { get; set; }
        public virtual DbSet<MonetaryAccountType> MonetaryAccountTypes { get; set; }
    }
}
