using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Webgood1.Models
{
    public class Lab2LibraryContext:DbContext
    {
        public virtual DbSet<Coments> Coment { get; set; }
        public virtual DbSet<Greadbook> Greadbooks { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Students> Student { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        public Lab2LibraryContext(DbContextOptions<Lab2LibraryContext> options): base(options)
        {
            Database.EnsureCreated();
        }

    }
}
