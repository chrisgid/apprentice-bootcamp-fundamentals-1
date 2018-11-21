namespace McrDigital.Bootcamp1.Checkout.Tests
{
    using System;
    using Xunit;
    using McrDigital.Bootcamp1.Checkout;

    public class ReceiptTests
    {
        Item itemA = new Item("A");
        Item itemB = new Item("B");
        Item itemC = new Item("C");
        Item itemD = new Item("D");

        [Fact]
        public void SingleItem()
        {
            var checkout = new Checkout();
            checkout.Scan(itemA);
            Assert.Equal(new string[] {
        "A: 50",
        "Total: 50"
      }, checkout.Receipt.Split("\n"));
        }

        [Fact]
        public void OneOfEach()
        {
            var checkout = new Checkout();

            checkout.Scan(itemA);
            checkout.Scan(itemB);
            checkout.Scan(itemC);
            checkout.Scan(itemD);

            Assert.Equal(new string[] {
        "A: 50",
        "B: 30",
        "C: 20",
        "D: 15",
        "Total: 115"
      }, checkout.Receipt.Split("\n"));
        }

        [Fact]
        public void Offers()
        {
            var checkout = new Checkout();

            checkout.Scan(itemA);
            checkout.Scan(itemA);
            checkout.Scan(itemB);
            checkout.Scan(itemA);
            checkout.Scan(itemC);
            checkout.Scan(itemD);
            checkout.Scan(itemB);

            Assert.Equal(new string[] {
        "A: 50",
        "A: 50",
        "B: 30",
        "A: 50 - 20 (3 for 130)",
        "C: 20",
        "D: 15",
        "B: 30 - 15 (2 for 45)",
        "Total: 210"
      }, checkout.Receipt.Split("\n"));
        }
    }
}