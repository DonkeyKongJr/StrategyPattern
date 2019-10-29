using System;

namespace StrategyPattern
{
    public interface ISaleStrategy
    {
        decimal CalculatePrice(decimal netPrice);
    }
}