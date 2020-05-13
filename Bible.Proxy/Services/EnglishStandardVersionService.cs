using Bible.Proxy.Services.Interfaces;
using Bible.Proxy.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Bible.Proxy.Services
{
    public class EnglishStandardVersionService : IEnglishStandardVersionServices
    {
        private BibleDBContext _context = new BibleDBContext();

        public List<EnglishStandardVersion> GetEnglishStandardVersion()
        {
            try
            {
                var list = (from bibleList in _context.EnglishStandardVersion select bibleList).ToList();

                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
