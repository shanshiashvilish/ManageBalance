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

        public string Withdraw(decimal amount, string transactionId)
        {
            decimal casinoBalance = _casinoBalanceManager.GetBalance();

            if (casinoBalance > amount)
            {
                ErrorCode decreaseCasinoBalance = _casinoBalanceManager.DecreaseBalance(amount, transactionId);

                if(decreaseCasinoBalance == ErrorCode.Success)
                {
                    _gameBalanceManager.IncreaseBalance(amount, transactionId);
                }
                else
                {
                    return nameof(decreaseCasinoBalance);
                }
            }

            ErrorCode result = _casinoBalanceManager.CheckTransaction(transactionId);

            return nameof(result);
        }
    }
}
