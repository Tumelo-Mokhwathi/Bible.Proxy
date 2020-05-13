using Bible.Proxy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bible.Proxy.Services.Interfaces
{
    public interface IKingJamesVersionService 
    {
        List<KingJamesVersion> GetKingJamesVersion();
    }
}
