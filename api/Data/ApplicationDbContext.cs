using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses  { get; set; }
        public DbSet<District> Districts  { get; set; }
        public DbSet<Faculty> Faculty  { get; set; }
        public DbSet<Grade> Grades  { get; set; }
        public DbSet<Guardian> Guardians  { get; set; }
        public DbSet<School> Schools  { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Students  { get; set; }
    }
}