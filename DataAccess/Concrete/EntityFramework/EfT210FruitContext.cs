using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfT210FruitContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CourseSpecification> CourseSpecifications { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<Lesson> Lessons{ get; set; }
        public DbSet<LessonVideo> LessonVideos { get; set; }


    }
}
