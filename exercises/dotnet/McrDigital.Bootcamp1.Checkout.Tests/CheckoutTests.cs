namespace McrDigital.Bootcamp1.Checkout.Tests
{
    using System;
    using Xunit;
    using McrDigital.Bootcamp1.Checkout;

    public class CheckoutTests
    {
        Item itemA = new Item("A");
        Item itemB = new Item("B");
        Item itemC = new Item("C");
        Item itemD = new Item("D");

        [Fact]
        public void OneA()
        {
            var checkout = new Checkout();
            

            checkout.Scan(itemA);

            Assert.Equal(50, checkout.Total);
        }

        [Fact]
        public void TwoA()
        {
            var checkout = new Checkout();

            checkout.Scan(itemA);
            checkout.Scan(itemA);

            Assert.Equal(100, checkout.Total);
        }

        [Fact]
        public void ThreeA()
        {
            var checkout = new Checkout();

            checkout.Scan(itemA);
            checkout.Scan(itemA);
            checkout.Scan(itemA);

            Assert.Equal(130, checkout.Total);
        }

        [Fact]
        public void SixA()
        {
            var checkout = new Checkout();

            checkout.Scan(itemA);
            checkout.Scan(itemA);
            checkout.Scan(itemA);
            checkout.Scan(itemA);
            checkout.Scan(itemA);
            checkout.Scan(itemA);

            Assert.Equal(260, checkout.Total);
        }
        [Fact]
        public void OneB()
        {
            var checkout = new Checkout();

            checkout.Scan(itemB);

            Assert.Equal(30, checkout.Total);
        }

        [Fact]
        public void TwoB()
        {
            var checkout = new Checkout();

            checkout.Scan(itemB);
            checkout.Scan(itemB);

            Assert.Equal(45, checkout.Total);
        }

        [Fact]
        public void FourB()
        {
            var checkout = new Checkout();

            checkout.Scan(itemB);
            checkout.Scan(itemB);
            checkout.Scan(itemB);
            checkout.Scan(itemB);

            Assert.Equal(90, checkout.Total);
        }

        [Fact]
        public void Simple()
        {
            var checkout = new Checkout();

            checkout.Scan(itemA);
            Assert.Equal(50, checkout.Total);

            checkout.Scan(itemB);
            Assert.Equal(80, checkout.Total);

            checkout.Scan(itemC);
            Assert.Equal(100, checkout.Total);

            checkout.Scan(itemD);
            Assert.Equal(115, checkout.Total);
        }

        [Fact]
        public void Incremental()
        {
            var checkout = new Checkout();

            checkout.Scan(itemA);
            Assert.Equal(50, checkout.Total);

            checkout.Scan(itemB);
            Assert.Equal(80, checkout.Total);

            checkout.Scan(itemA);
            Assert.Equal(130, checkout.Total);

            checkout.Scan(itemA);
            Assert.Equal(160, checkout.Total);

            checkout.Scan(itemB);
            Assert.Equal(175, checkout.Total);

            checkout.Scan(itemC);
            Assert.Equal(195, checkout.Total);

            checkout.Scan(itemB);
            Assert.Equal(225, checkout.Total);

            checkout.Scan(itemC);
            Assert.Equal(245, checkout.Total);

            checkout.Scan(itemD);
            Assert.Equal(260, checkout.Total);

            checkout.Scan(itemD);
            Assert.Equal(275, checkout.Total);

            checkout.Scan(itemD);
            Assert.Equal(290, checkout.Total);

            checkout.Scan(itemC);
            Assert.Equal(310, checkout.Total);
        }

        [Fact]
        public void FourC()
        {
            var checkout = new Checkout();

            checkout.Scan(itemC);
            checkout.Scan(itemC);
            checkout.Scan(itemC);
            checkout.Scan(itemC);
            Assert.Equal(70, checkout.Total);
        }
    }
}
