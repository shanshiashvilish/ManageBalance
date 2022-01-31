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
            throw new System.NotImplementedException();
        }

        public string Deposit(decimal amount, string transactionId)
        {
            decimal gameBalance = _gameBalanceManager.GetBalance();

            if (gameBalance > amount)
            {
                ErrorCode decreaseCasinoBalance = _gameBalanceManager.DecreaseBalance(amount, transactionId);

                if (decreaseCasinoBalance == ErrorCode.Success)
                {
                    _casinoBalanceManager.IncreaseBalance(amount, transactionId);
                }
                else
                {
                    return nameof(decreaseCasinoBalance);
                }
            }

            ErrorCode result = _gameBalanceManager.CheckTransaction(transactionId);

            return nameof(result);
        }
    }
}
