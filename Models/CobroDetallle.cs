using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlmaMaria_AP1_1.Models;

public class CobroDetallle
{
    [Key]
    public int DetalleId { get; set; }

    public int CobroId {  get; set; }

    public int PrestamoId { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio. ")]
    [Range(minimum: 0.1, maximum: 9999999999, ErrorMessage = "Ingrese un cantidad válida.")]
    public Decimal ValorCobrado { get; set; }

    [ForeignKey("CobroId")]
    public ICollection<Cobros> Cobros { get; set; } = new List<Cobros>();

    [ForeignKey("PrestamoId")]
    public ICollection<Prestamos> Prestamos { get; set; } = new List<Prestamos>();
}
