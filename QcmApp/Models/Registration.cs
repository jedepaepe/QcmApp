using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QcmApp.Models
{
    public class Registration
    {
        public int Id { get; set; }

        [Required]
        public bool Active { get; set; }

        [Required]
        public User Student { get; set; }
    }
}
