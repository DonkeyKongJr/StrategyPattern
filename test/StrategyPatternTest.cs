using System;
using FluentAssertions;
using src;
using Xunit;

namespace StrategyPattern
{
    public class StrategyPatternTest
    {
        [Fact]
        public void RegularSale_ShouldReturnTotalOfAllArticles()
        {
            var strategy = new RegularSaleStrategy();
            var customer = new Customer(strategy);

            customer.AddArticle(50);
            customer.AddArticle(30);
            customer.AddArticle(20);

            var total = customer.GetTotal();

            total.Should().Be(100);
        }

        [Fact]
        public void SummerSale_ShouldReturnTotalOfAllArticlesWithDiscount()
        {
            var strategy = new SummerSaleStrategy();
            var customer = new Customer(strategy);

            customer.AddArticle(50);
            customer.AddArticle(30);
            customer.AddArticle(20);

            var total = customer.GetTotal();

            total.Should().Be(85);
        }

        [Fact]
        public void WinterSale_ShouldReturnTotalOfAllArticlesWithDiscount()
        {
            var strategy = new WinterSaleStrategy();
            var customer = new Customer(strategy);

            customer.AddArticle(50);
            customer.AddArticle(30);
            customer.AddArticle(20);

            var total = customer.GetTotal();

            total.Should().Be(75);
        }
    }
}