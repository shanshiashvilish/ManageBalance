using BalanceManager.Api.DataContracts;
using BalanceManager.Core.CasinoBalance;
using BalanceManager.Core.GameBalance;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BalanceManager.Api.Controllers
{
    [Route("api/")]
    public class BalanceController : Controller
    {
        private readonly IGameBalanceService _gameBalanceService;
        private readonly ICasinoBalanceService _casinoBalanceService;
        private readonly string _fakeTransactionId;

        public BalanceController(IGameBalanceService gameBalanceService, 
                                 ICasinoBalanceService casinoBalanceService)
        {
            _gameBalanceService = gameBalanceService;
            _casinoBalanceService = casinoBalanceService;
            _fakeTransactionId = new Guid().ToString();
        }

        [HttpGet("balance")]
        public ActionResult Balance()
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                decimal result = _casinoBalanceService.GetBalance();

                return Ok(BalanceDataContract.BuildFrom(result));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Casino >> Game
        [HttpPost("withdraw/{transactionId}/{amount}")]
        public ActionResult Withdraw(string transactionId, int amount)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                transactionId = _fakeTransactionId;

                var result = _casinoBalanceService.Withdraw(amount, transactionId);

                return Ok(WithdrawDataContract.BuildFrom(result));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Game >> Casino
        [HttpPost("deposit/{transactionId}/{amount}")]
        public ActionResult Deposit(string transactionId, int amount)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                transactionId = _fakeTransactionId;

                var result = _gameBalanceService.Deposit(amount, transactionId);

                return Ok(DepositDataContract.BuildFrom(result));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
