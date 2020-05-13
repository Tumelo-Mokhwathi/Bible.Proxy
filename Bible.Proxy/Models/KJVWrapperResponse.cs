using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bible.Proxy.Models
{
    public class KJVWrapperResponse
    {
        public int Code { get; set; }
        public List<KingJamesVersion> KingJamesVersion { get; set; }
        public string Source { get; set; }
    }
}
