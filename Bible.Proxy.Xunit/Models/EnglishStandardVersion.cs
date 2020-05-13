using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Bible.Proxy.Xunit.Models
{
    public class EnglishStandardVersion
    {
        [Theory, AutoData]
        public void SetPropertyEnglishStandardVersionVerseId(string VerseId, Proxy.Models.EnglishStandardVersion model)
        {
            model.VerseId = VerseId;

            Assert.Equal(VerseId, model.VerseId);
        }

        [Theory, AutoData]
        public void SetPropertyEnglishStandardVersionScriptures(string Scriptures, Proxy.Models.EnglishStandardVersion model)
        {
            model.Scriptures = Scriptures;

            Assert.Equal(Scriptures, model.Scriptures);
        }
    }
}
