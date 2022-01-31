
namespace BalanceManager.Api.DataContracts
{
    public class BalanceDataContract
    {
        public decimal CasinoBalance { get; set; }

        public static BalanceDataContract BuildFrom(decimal balance)
        {
            return new BalanceDataContract
            {
                CasinoBalance = balance
            };
        }
    }
}
