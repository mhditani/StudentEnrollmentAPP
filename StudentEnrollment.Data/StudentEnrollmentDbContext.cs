using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentEnrollment.Data.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentEnrollment.Data.Configuration.CourseConfiguration;

namespace StudentEnrollment.Data
{
    public class StudentEnrollmentDbContext : IdentityDbContext
    {
        public StudentEnrollmentDbContext(DbContextOptions<StudentEnrollmentDbContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CourseConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());


        }
    }
}
