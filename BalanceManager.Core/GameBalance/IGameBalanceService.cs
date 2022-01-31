using Balances;

namespace BalanceManager.Core.GameBalance
{
    public interface IGameBalanceService
    {
        decimal GetBalance();
        public ErrorCode Deposit(decimal amount, string transactionId);
    }
}
