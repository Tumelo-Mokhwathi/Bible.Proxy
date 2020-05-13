using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bible.Proxy.Models
{
    public class KingJamesVersion
    {
        [Key]
        [Required]
        public string VerseId { get; set; }
        public string Scripture { get; set; }
    }
}
