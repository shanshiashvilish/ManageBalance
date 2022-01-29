﻿using Balances;

namespace BalanceManager.Core.CasinoBalance
{
    public interface ICasinoBalanceService
    {
        public ErrorCode CheckTransaction(string transactionId);
        public ErrorCode DecreaseBalance(decimal amount, string transactionId);
        public decimal GetBalance();
        public ErrorCode IncreaseBalance(decimal amount, string transactionId);
        public ErrorCode Rollback(string transactionId);
    }
}