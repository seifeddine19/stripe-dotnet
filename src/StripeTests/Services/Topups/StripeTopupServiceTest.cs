namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class StripeTopupServiceTest : BaseStripeTest
    {
        private const string TopupId = "po_123";

        private StripeTopupService service;
        private StripeTopupCreateOptions createOptions;
        private StripeTopupUpdateOptions updateOptions;
        private StripeTopupListOptions listOptions;

        public StripeTopupServiceTest()
        {
            this.service = new StripeTopupService();

            this.createOptions = new StripeTopupCreateOptions()
            {
                Amount = 123,
                Currency = "usd",
                StatementDescriptor = "descriptor",
            };

            this.updateOptions = new StripeTopupUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new StripeTopupListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var topup = this.service.Create(this.createOptions);
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var topup = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public void Get()
        {
            var topup = this.service.Get(TopupId);
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var topup = await this.service.GetAsync(TopupId);
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public void List()
        {
            var topups = this.service.List(this.listOptions);
            Assert.NotNull(topups);
            Assert.Equal("list", topups.Object);
            Assert.Single(topups.Data);
            Assert.Equal("topup", topups.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var topups = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(topups);
            Assert.Equal("list", topups.Object);
            Assert.Single(topups.Data);
            Assert.Equal("topup", topups.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var topup = this.service.Update(TopupId, this.updateOptions);
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var topup = await this.service.UpdateAsync(TopupId, this.updateOptions);
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }
    }
}
