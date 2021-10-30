using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QcmApp.Models
{
    public class Answer
    {
        public int Id { get; set; }

        [Required]
        public Option Option { get; set; }

        [Required]
        public Test Test { get; set; }
    }
}
