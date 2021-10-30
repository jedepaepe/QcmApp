using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QcmApp.Models
{
    public class Quizz
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(128)")]
        public string Title { get; set; }

        [Required]
        public Course Course { get; set; }

        public ICollection<Question> Questions { get; set; }

        public ICollection<Test> Tests { get; set; }
    }
}
