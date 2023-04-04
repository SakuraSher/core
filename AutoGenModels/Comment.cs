using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WorkingWithEFCore.Autogen
{
    [Keyless]
    [Table("Comment")]
    public partial class Comment
    {
        public int Id { get; set; }
        [Column("comment")]
        [StringLength(10)]
        public string? Comment1 { get; set; }
    }
}
