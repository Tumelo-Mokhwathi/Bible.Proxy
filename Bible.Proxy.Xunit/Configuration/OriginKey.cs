using Xunit;

namespace Bible.Proxy.Xunit.Configuration
{
    public class OriginKey
    {
        [Fact]
        public void SetOriginalKeyProperty()
        {
            const string specificOrigins = "_specificOrigins";

            Assert.Equal(specificOrigins, Proxy.Configuration.OriginKey.specificOrigins);
            Assert.Equal("_specificOrigins", Proxy.Configuration.OriginKey.specificOrigins);
        }
    }
}
