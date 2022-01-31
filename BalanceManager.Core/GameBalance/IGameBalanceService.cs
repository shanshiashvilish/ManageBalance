
namespace BalanceManager.Core.GameBalance
{
    public interface IGameBalanceService
    {
        decimal GetBalance();
        public string Deposit(decimal amount, string transactionId);
    }
}
