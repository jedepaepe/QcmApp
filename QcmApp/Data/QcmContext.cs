using Microsoft.EntityFrameworkCore;
using QcmApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QcmApp.Data
{
    public class QcmContext : DbContext
    {
        public QcmContext(DbContextOptions<QcmContext> options) : base(options)
        {
        }

        public DbSet<Answer> Answer { get; set; }

        public DbSet<Course> Course { get; set; }

        public DbSet<Option> Option { get; set; }

        public DbSet<Question> Question { get; set; }

        public DbSet<Quizz> Quizz { get; set; }

        public DbSet<Registration> Registration { get; set; }

        public DbSet<Test> Test { get; set; }

        public DbSet<User> User { get; set; }
    }
}
