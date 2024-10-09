using System.ComponentModel.DataAnnotations;

namespace AlmaMaria_AP1_1.Models;

public class Deudores
{
    [Key]
    public int DeudorId { get; set; }

    public string Nombres { get; set; }
}
