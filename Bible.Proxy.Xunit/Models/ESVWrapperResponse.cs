using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Bible.Proxy.Xunit.Models
{
    public class ESVWrapperResponse
    {
        [Theory, AutoData]
        public void SetPropertyESVWrapperResponseCode(int Code, Proxy.Models.ESVWrapperResponse model)
        {
            model.Code = Code;

            Assert.Equal(Code, model.Code);
        }

        [Theory, AutoData]
        public void SetPropertyESVWrapperResponseSource(string Source, Proxy.Models.ESVWrapperResponse model)
        {
            model.Source = Source;

            Assert.Equal(Source, model.Source);
        }

        [Theory, AutoData]
        public void SetPropertyESVWrapperResponseAmericanStandardVersion(List<Proxy.Models.EnglishStandardVersion> EnglishStandardVersion, Proxy.Models.ESVWrapperResponse model)
        {
            model.EnglishStandardVersion = EnglishStandardVersion;

            Assert.Equal(EnglishStandardVersion, model.EnglishStandardVersion);
        }
    }
}
