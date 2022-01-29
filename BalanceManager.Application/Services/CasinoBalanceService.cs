using Balances;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalanceManager.Application.Services
{
    public class CasinoBalanceService
    {
        private readonly CasinoBalanceManager _casinoBalanceManager;

        public CasinoBalanceService(CasinoBalanceManager casinoBalanceManager)
        {
            _casinoBalanceManager = casinoBalanceManager;
        }



    }
}
