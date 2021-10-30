using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QcmApp.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(128)")]
        public string Title { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar(3)")]
        public string Type { get; set; }

        [Required]
        public Quizz Quizz { get; set; }

        public ICollection<Option> Options { get; set; }
    }
}
