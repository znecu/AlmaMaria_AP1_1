using System.ComponentModel.DataAnnotations;

namespace AlmaMaria_AP1_1.Models;

public class Prestamos
{
    [Key]
    public int PrestamoId { get; set; }

    [Required]
    [RegularExpression(@"^[a-Az-Z\s]+$", ErrorMessage = "En este campo solo se permiten letras. ")]
    public string? Deudor { get; set; }  

    [Required]
    [RegularExpression(@"^[a-Az-Z\s]+$", ErrorMessage = "En este campo solo se permiten letras. ")]
    public string? Concepto { get; set; }


    [Required]
    [RegularExpression(@"^[0-9]", ErrorMessage =("Este campo solo permite números. "))]
    public decimal Monto { get; set; }
}
