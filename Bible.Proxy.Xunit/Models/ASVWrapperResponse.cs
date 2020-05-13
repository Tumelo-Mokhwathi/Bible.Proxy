using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Bible.Proxy.Xunit.Models
{
    public class ASVWrapperResponse
    {
        [Theory, AutoData]
        public void SetPropertyASVWrapperResponseCode(int Code, Proxy.Models.ASVWrapperResponse model)
        {
            model.Code = Code;

            Assert.Equal(Code, model.Code);
        }

        [Theory, AutoData]
        public void SetPropertyASVWrapperResponseSource(string Source, Proxy.Models.ASVWrapperResponse model)
        {
            model.Source = Source;

            Assert.Equal(Source, model.Source);
        }

        [Theory, AutoData]
        public void SetPropertyASVWrapperResponseAmericanStandardVersion(Proxy.Models.AmericanStandardVersion[] AmericanStandardVersion, Proxy.Models.ASVWrapperResponse model)
        {
            model.AmericanStandardVersion = AmericanStandardVersion;

            Assert.Equal(AmericanStandardVersion, model.AmericanStandardVersion);
        }
    }
}
