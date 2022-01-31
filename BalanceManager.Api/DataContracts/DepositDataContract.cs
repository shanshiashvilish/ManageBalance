using Balances;

namespace BalanceManager.Api.DataContracts
{
    public class DepositDataContract
    {
        public string Status { get; set; }

        public static DepositDataContract BuildFrom(ErrorCode responseMessage)
        {
            return new DepositDataContract
            {
                Status = responseMessage.ToString()
            };
        }
    }
}
