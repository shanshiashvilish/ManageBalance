using BalanceManager.Core.GameBalance;
using Balances;

namespace BalanceManager.Application.Services
{
    public class GameBalanceService : IGameBalanceService
    {
        private readonly GameBalanceManager _gameBalanceManager;
        private readonly CasinoBalanceManager _casinoBalanceManager;

        public GameBalanceService(GameBalanceManager gameBalanceManager,
                                  CasinoBalanceManager casinoBalanceManager)
        {
            _gameBalanceManager = gameBalanceManager;
            _casinoBalanceManager = casinoBalanceManager;
        }

        public decimal GetBalance()
        {
            return _gameBalanceManager.GetBalance();
        }

        public ErrorCode Deposit(decimal amount, string transactionId)
        {
            ErrorCode decreaseCasinoBalance = _gameBalanceManager.DecreaseBalance(amount, transactionId);

            ErrorCode result = decreaseCasinoBalance == ErrorCode.Success 
                               ? _casinoBalanceManager.IncreaseBalance(amount, transactionId) 
                               : decreaseCasinoBalance;

            return result;
        }
    }
}
