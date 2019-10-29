using StrategyPattern;

namespace src
{
    public class WinterSaleStrategy : ISaleStrategy
    {
        public decimal CalculatePrice(decimal netPrice)
        {
            return netPrice * 0.75m;
        }
    }
}