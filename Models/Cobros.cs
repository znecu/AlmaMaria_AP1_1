using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlmaMaria_AP1_1.Models;

public class Cobros
{
    [Key]
    public int CobroId { get; set; }

    [Required]
    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Este campo es obligatorio. ")]
    [Range(minimum: 0.1, maximum: 9999999999, ErrorMessage = "Ingrese un cantidad válida.")]
    public decimal Monto { get; set; }

    public int DeudorId { get; set; }
    [ForeignKey("DeudorId")]
    public Deudores? Deudores { get; set; } 

    public ICollection<CobroDetalle> CobroDetalle { get; set; } = new List<CobroDetalle>();  
}
