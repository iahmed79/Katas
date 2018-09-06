namespace Supermarket
{
    using NUnit.Framework;

    [TestFixture]
    public class SupermarketTests
    {
        private PricingRules pricingRules;
        private Checkout checkout;

        [SetUp]
        public void Setup()
        {
            this.pricingRules = new PricingRules();
            this.checkout = new Checkout(this.pricingRules);
        }

        [Test]
        public void GivenACheckoutWhenScan()
        {
            var item = new Item("A", 1.35M);

            this.checkout.Scan(item);

            Assert.That(this.checkout.Total, Is.Not.EqualTo(0));
        }
    }

    public struct Item
    {
        private string barcode;
        private decimal unitPrice;

        public Item(string code, decimal unitPrice)
        {
            this.barcode = code;
            this.unitPrice = unitPrice;
        }
    }

    public class Checkout
    {
        public Checkout(PricingRules rules)
        {
            this.Total = 1;
        }

        public decimal Total { get; internal set; }

        public void Scan(Item item)
        {
        }
    }

    public class PricingRules
    {
    }
}
