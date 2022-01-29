using Balances;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalanceManager.Application.Services
{
    public class GameBalanceService
    {
        private readonly GameBalanceManager _gameBalanceManager;

        public GameBalanceService(GameBalanceManager gameBalanceManager)
        {
            _gameBalanceManager = gameBalanceManager;
        }

    }
}
