using Microsoft.AspNetCore.Mvc;
using System;

using System.Threading.Tasks;

namespace BalanceManager.Api.Controllers
{
    [Route("api/[controller]")]
    public class BalanceController : Controller
    {
        [HttpGet("Balance")]
        public async Task<ActionResult> Balance()
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Withdraw")]
        public async Task<ActionResult> Withdraw(string transactionId, int amount)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {


                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Deposit")]
        public async Task<ActionResult> Deposit(string transactionId, int amount)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {


                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }


}
