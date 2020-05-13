using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bible.Proxy.Models
{
    public class ASVWrapperResponse
    {
        public int Code { get; set; }
        public AmericanStandardVersion[] AmericanStandardVersion { get; set; }
        public string Source { get; set; }
    }
}
