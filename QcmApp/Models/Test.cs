using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QcmApp.Models
{
    public class Test
    {
        public int Id { get; set; }
        [Required]
        public User Student { get; set; }
        [Required]
        public Quizz Quizz { get; set; }
        [Required]
        public DateTime Start { get; set; }
    }
}
