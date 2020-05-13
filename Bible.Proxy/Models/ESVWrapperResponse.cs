using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bible.Proxy.Models
{
    public class ESVWrapperResponse 
    {
        public int Code { get; set; }
        public List<EnglishStandardVersion> EnglishStandardVersion { get; set; }
        public string Source { get; set; } 
    }
}
