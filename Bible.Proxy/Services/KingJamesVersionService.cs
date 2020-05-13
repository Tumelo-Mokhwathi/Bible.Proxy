using Bible.Proxy.Models;
using Bible.Proxy.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bible.Proxy.Services
{
    public class KingJamesVersionService : IKingJamesVersionService
    {
        private BibleDBContext _context = new BibleDBContext();
        public List<KingJamesVersion> GetKingJamesVersion()
        {
           try
           {
                var list = (from kjvList in _context.KingJamesVersion select kjvList).ToList();

                return list;
           }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
