using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packt.Shared
{
    public  class Comment
    {
        [Key]
        public int Id { get; set; }
        public string? Cmt  { get; set; }
    }
}
