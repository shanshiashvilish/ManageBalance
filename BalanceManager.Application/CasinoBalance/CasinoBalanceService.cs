using BalanceManager.Core.CasinoBalance;
using Balances;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalanceManager.Application.Services
{
    public class CasinoBalanceService : ICasinoBalanceService
    {
        private readonly CasinoBalanceManager _casinoBalanceManager;

        public CasinoBalanceService(CasinoBalanceManager casinoBalanceManager)
        {
            _casinoBalanceManager = casinoBalanceManager;
        }

        public ErrorCode CheckTransaction(string transactionId)
        {
            return _casinoBalanceManager.CheckTransaction(transactionId);
        }

        public ErrorCode DecreaseBalance(decimal amount, string transactionId)
        {
            return _casinoBalanceManager.DecreaseBalance(amount, transactionId);
        }

        public decimal GetBalance()
        {
            return _casinoBalanceManager.GetBalance();
        }

        public ErrorCode IncreaseBalance(decimal amount, string transactionId)
        {
            return _casinoBalanceManager.IncreaseBalance(amount, transactionId);
        }

        public ErrorCode Rollback(string transactionId)
        {
            return _casinoBalanceManager.Rollback(transactionId);
        }
    }
}
