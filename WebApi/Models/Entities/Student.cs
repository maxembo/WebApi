using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities;
public class Student
{
    [Key]
    public int Id { get; set; }

    [Range(0, 50), DefaultValue(0)]
    public int Age { get; set; } = 18;

    [Required, MaxLength(20)]
    public string Name { get; set; } = string.Empty;

    [Required, MaxLength(20)]
    public string City { get; set; } = string.Empty;

    [Required, Range(0, 500), DefaultValue(0)]
    public int Scores { get; set; } = 0;
}
