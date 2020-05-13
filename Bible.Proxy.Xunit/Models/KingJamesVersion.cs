using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Bible.Proxy.Xunit.Models
{
    public class KingJamesVersion
    {
        [Theory, AutoData]
        public void SetPropertyKingJamesVersionVerseId(string VerseId, Proxy.Models.KingJamesVersion model)
        {
            model.VerseId = VerseId;

            Assert.Equal(VerseId, model.VerseId);
        }

        [Theory, AutoData]
        public void SetPropertyKingJamesVersionScripture(string Scripture, Proxy.Models.KingJamesVersion model)
        {
            model.Scripture = Scripture;

            Assert.Equal(Scripture, model.Scripture);
        }
    }
}
