using BalanceManager.Core.CasinoBalance;
using Balances;

namespace BalanceManager.Application.Services
{
    public class CasinoBalanceService : ICasinoBalanceService
    {
        private readonly CasinoBalanceManager _casinoBalanceManager;
        private readonly GameBalanceManager _gameBalanceManager;

        public CasinoBalanceService(CasinoBalanceManager casinoBalanceManager,
                                    GameBalanceManager gameBalanceManager)
        {
            _casinoBalanceManager = casinoBalanceManager;
            _gameBalanceManager = gameBalanceManager;
        }

        public decimal GetBalance()
        {
            return _casinoBalanceManager.GetBalance();
        }

        public ErrorCode Withdraw(decimal amount, string transactionId)
        {
            ErrorCode decreaseCasinoBalance = _casinoBalanceManager.DecreaseBalance(amount, transactionId);

            ErrorCode result = decreaseCasinoBalance == ErrorCode.Success 
                               ? _gameBalanceManager.IncreaseBalance(amount, transactionId) 
                               : decreaseCasinoBalance;

            return result;
        }
    }
}
