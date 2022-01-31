using Balances;

namespace BalanceManager.Core.CasinoBalance
{
    public interface ICasinoBalanceService
    {
        decimal GetBalance();
        public ErrorCode Withdraw(decimal amount, string transactionId);
    }
}
