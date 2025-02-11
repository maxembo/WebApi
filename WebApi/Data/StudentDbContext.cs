using Microsoft.EntityFrameworkCore;
using WebApi.Configurations;
using WebApi.Models;
using WebApi.Models.Entities;

namespace WebApi.Data;

public class StudentDbContext : DbContext
{
    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
    { }

    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new StudentConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
