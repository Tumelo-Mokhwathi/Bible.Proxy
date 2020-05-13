using Bible.Proxy.Services.Interfaces;
using Bible.Proxy.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Bible.Proxy.Services
{
    public class AmericanStandardVersionService : IAmericanStandardVersionService
    {
        private BibleDBContext _context = new BibleDBContext();

        public AmericanStandardVersion[] GetAmericanStandardVersion()
        {
            try
            {
                var list = (from asvList in _context.AmericanStandardVersion select asvList).ToArray();

                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
