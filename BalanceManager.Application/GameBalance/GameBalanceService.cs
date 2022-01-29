using BalanceManager.Core.GameBalance;
using Balances;
using System;
namespace BalanceManager.Application.Services
{
    public class GameBalanceService : IGameBalanceService
    {
        private readonly GameBalanceManager _gameBalanceManager;

        public GameBalanceService(GameBalanceManager gameBalanceManager)
        {
            _gameBalanceManager = gameBalanceManager;
        }

        public ErrorCode CheckTransaction(string transactionId)
        {
            return _gameBalanceManager.CheckTransaction(transactionId);
        }

        public ErrorCode DecreaseBalance(decimal amount, string transactionId)
        {
            return _gameBalanceManager.DecreaseBalance(amount, transactionId);
        }

        public decimal GetBalance()
        {
            return _gameBalanceManager.GetBalance();
        }

        public ErrorCode IncreaseBalance(decimal amount, string transactionId)
        {
            return _gameBalanceManager.IncreaseBalance(amount, transactionId);
        }

        public ErrorCode Rollback(string transactionId)
        {
            return _gameBalanceManager.Rollback(transactionId);
        }
    }
}
