using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlmaMaria_AP1_1.Models;

public class Prestamos
{
    [Key]
    public int PrestamoId { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio. ")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "En este campo solo se permiten letras. ")]
    public string? Concepto { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio. ")]
    [Range(minimum: 0.1, maximum: 9999999999, ErrorMessage = "Ingrese un numero valido")]
    public decimal Monto { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio. ")]
    [Range(minimum: 0.1, maximum: 9999999999, ErrorMessage = "Ingrese un número válido. ")]
    public decimal Balance { get; set; }

    public int CobroId { get; set; }
    [ForeignKey("CobroId")]
    public Cobros? Cobros { get; set; }

    public int DeudorId { get; set; }
    [ForeignKey("DeudorId")]
    public Deudores? Deudores { get; set; }


}
