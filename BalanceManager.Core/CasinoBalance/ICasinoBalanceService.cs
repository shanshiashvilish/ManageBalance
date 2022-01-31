
namespace BalanceManager.Core.CasinoBalance
{
    public interface ICasinoBalanceService
    {
        decimal GetBalance();
        public string Withdraw(decimal amount, string transactionId);
    }
}
