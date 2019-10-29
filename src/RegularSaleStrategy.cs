using StrategyPattern;

namespace src
{
    public class RegularSaleStrategy : ISaleStrategy
    {
        public decimal CalculatePrice(decimal netPrice)
        {
            return netPrice;
        }
    }
}