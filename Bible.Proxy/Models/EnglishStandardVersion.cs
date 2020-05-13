using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bible.Proxy.Models
{
    public partial class EnglishStandardVersion
    {
        [Key]
        [Required]
        public string VerseId { get; set; }
        public string Scriptures { get; set; }
    }
}
