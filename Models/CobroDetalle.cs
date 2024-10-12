using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlmaMaria_AP1_1.Models;

public class CobroDetalle
{
    [Key]
    public int DetalleId { get; set; }

    public int CobroId { get; set; }
    [ForeignKey("CobroId")]
    public Cobros? Cobros { get; set; }  

    public int PrestamoId { get; set; }
    [ForeignKey("PrestamoId")]
    public Prestamos? Prestamo { get; set; }  

    [Required(ErrorMessage = "Este campo es obligatorio. ")]
    [Range(minimum: 0.1, maximum: 9999999999, ErrorMessage = "Ingrese un cantidad válida.")]
    public decimal ValorCobrado { get; set; }  
}
