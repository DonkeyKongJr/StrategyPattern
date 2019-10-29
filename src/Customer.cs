using System.Collections.Generic;
using System.Linq;
using StrategyPattern;

namespace src
{
    public class Customer
    {
        private IList<decimal> articles;
        private readonly ISaleStrategy _saleStrategy;

        public Customer(ISaleStrategy saleStrategy)
        {
            articles = new List<decimal>();
            _saleStrategy = saleStrategy;
        }

        public void AddArticle(decimal price)
        {
            var calculatedPrice = _saleStrategy.CalculatePrice(price);
            articles.Add(calculatedPrice);
        }

        public decimal GetTotal()
        {
            return articles.Sum();
        }
    }
}