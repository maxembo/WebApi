using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models.Entities;

namespace WebApi.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("student");

        builder.HasKey(student => student.Id);

        builder.Property(student => student.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(student => student.Age)
            .HasColumnName("age")
            .IsRequired();

        builder.Property(student => student.Name)
            .HasMaxLength(20)
            .HasColumnName("name")
            .IsRequired();

        builder.Property(student => student.City)
            .HasMaxLength(20)
            .HasColumnName("city")
            .IsRequired();

        builder.Property(student => student.Scores)
            .HasColumnName("score")
            .IsRequired();
    }
}
