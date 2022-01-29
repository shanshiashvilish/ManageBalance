using Balances;
using System.Threading.Tasks;

namespace BalanceManager.Core.GameBalance
{
    public interface IGameBalanceService
    {
        public ErrorCode CheckTransaction(string transactionId);
        public ErrorCode DecreaseBalance(decimal amount, string transactionId);
        public decimal GetBalance();
        public ErrorCode IncreaseBalance(decimal amount, string transactionId);
        public ErrorCode Rollback(string transactionId);
    }
}
