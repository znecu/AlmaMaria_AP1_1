using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlmaMaria_AP1_1.Models;

public class Cobros
{
    [Key]
    public int CobroId { get; set; }

    public Prestamos? Prestamos { get; set; }

    [Required]
    public DateTime Fecha { get; set; }

    public int DeudorId { get; set; }
    [ForeignKey("DeudorId")]
    public Deudores? Deudores { get; set; }

    [ForeignKey("CobroId")]
    public ICollection<CobroDetalle> CobroDetalle { get; set; } = new List<CobroDetalle>();
}
