using Balances;

namespace BalanceManager.Api.DataContracts
{
    public class WithdrawDataContract
    {
        public string Status { get; set; }

        public static WithdrawDataContract BuildFrom(ErrorCode responseMessage)
        {
            return new WithdrawDataContract
            {
                Status = responseMessage.ToString()
            };
        }
    }
}
