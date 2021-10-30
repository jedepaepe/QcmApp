using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QcmApp.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(4)")]
        public string Code { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(128)")]
        public string Description { get; set; }

        [Required]
        public int Capacity { get; set; }

        public ICollection<User> Registrations { get; set; }

        public ICollection<Quizz> Quizzs { get; set; }
    }
}
