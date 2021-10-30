using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QcmApp.Models
{
    public class Option
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(256)")]
        public string Title { get; set; }

        [Required]
        public bool Correct { get; set; }

        [Required]
        public Question Question { get; set; }
    }
}
