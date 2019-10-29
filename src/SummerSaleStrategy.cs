using StrategyPattern;

namespace src
{
    public class SummerSaleStrategy : ISaleStrategy
    {
        public decimal CalculatePrice(decimal netPrice)
        {
            return netPrice * 0.85m;
        }
    }
}