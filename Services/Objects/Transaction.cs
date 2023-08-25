namespace BudgetApi.Services
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public TransactionType TransactionType { get; set; }
        public MonetaryAccount Account { get; set; }
        public MonetaryAccount? ReceivingAccount { get; set; }
    }
}
