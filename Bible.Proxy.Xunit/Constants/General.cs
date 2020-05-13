using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Bible.Proxy.Xunit.Constants
{
    public class General
    {
        [Fact]
        public void SetGeneralPropertyForCode()
        {
            const int Code = 200;

            Assert.Equal(Code, Proxy.Constants.General.Code);
            Assert.Equal(200, Proxy.Constants.General.Code);
        }

        [Fact]
        public void SetGeneralPropertyForKJVPrefixSourceName()
        {
            const string KJVPrefixSourceName = "kingjamesversion.source.proxy";

            Assert.Equal(KJVPrefixSourceName, Proxy.Constants.General.KJVPrefixSourceName);
            Assert.Equal("kingjamesversion.source.proxy", Proxy.Constants.General.KJVPrefixSourceName);
        }

        [Fact]
        public void SetGeneralPropertyForASVPrefixSourceName()
        {
            const string ASVPrefixSourceName = "americanstandardversion.source.proxy";

            Assert.Equal(ASVPrefixSourceName, Proxy.Constants.General.ASVPrefixSourceName);
            Assert.Equal("americanstandardversion.source.proxy", Proxy.Constants.General.ASVPrefixSourceName);
        }

        [Fact]
        public void SetGeneralPropertyForESVPrefixSourceName()
        {
            const string ESVPrefixSourceName = "englishandardversion.source.proxy";

            Assert.Equal(ESVPrefixSourceName, Proxy.Constants.General.ESVPrefixSourceName);
            Assert.Equal("englishandardversion.source.proxy", Proxy.Constants.General.ESVPrefixSourceName);
        }
    }
}
