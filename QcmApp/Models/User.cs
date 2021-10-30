using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QcmApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(128)")]
        public string Pseudo { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(128)")]
        public string Password { get; set; }

        [Required]
        //TODO
        public string FullName { get; set; }

        //TODO
        public DateTime Birthdate { get; set; }

        [Required]
        public bool role { get; set; }

        // as a student, user is registred to courses
        public ICollection<Course> Registrations { get; set; }

        public ICollection<Test> Tests { get; set; }
    }
}
