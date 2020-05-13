using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bible.Proxy.Models
{
    public partial class AmericanStandardVersion
    {
        [Key]
        [Required]
        public string VerseId { get; set; }
        public string Scriptures { get; set; }
    }
}
