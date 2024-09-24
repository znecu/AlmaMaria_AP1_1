using System.ComponentModel.DataAnnotations;

namespace AlmaMaria_AP1_1.Models;

public class Registro
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Nombres { get; set; }
}
