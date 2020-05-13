using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Bible.Proxy.Xunit.Models
{
    public class KJVWrapperResponse
    {
        [Theory, AutoData]
        public void SetPropertyKJVWrapperResponseCode(int Code, Proxy.Models.KJVWrapperResponse model)
        {
            model.Code = Code;

            Assert.Equal(Code, model.Code);
        }

        [Theory, AutoData]
        public void SetPropertyKJVWrapperResponseSource(string Source, Proxy.Models.KJVWrapperResponse model)
        {
            model.Source = Source;

            Assert.Equal(Source, model.Source);
        }

        [Theory, AutoData]
        public void SetPropertyKJVWrapperResponseKingJamesVersion(List<Proxy.Models.KingJamesVersion> KingJamesVersion, Proxy.Models.KJVWrapperResponse model)
        {
            model.KingJamesVersion = KingJamesVersion; 

            Assert.Equal(KingJamesVersion, model.KingJamesVersion);
        }
    }
}
