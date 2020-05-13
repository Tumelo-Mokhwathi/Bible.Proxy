using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Bible.Proxy.Xunit.Models
{
    public class AmericanStandardVersion
    {
        [Theory, AutoData]
        public void SetPropertyAmericanStandardVersionVerseId(string VerseId, Proxy.Models.AmericanStandardVersion model)
        {
            model.VerseId = VerseId;

            Assert.Equal(VerseId, model.VerseId);
        }

        [Theory, AutoData]
        public void SetPropertyAmericanStandardVersionScripture(string Scriptures, Proxy.Models.AmericanStandardVersion model)
        {
            model.Scriptures = Scriptures;

            Assert.Equal(Scriptures, model.Scriptures);
        }
    }
}
