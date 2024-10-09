﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlmaMaria_AP1_1.Models;

public class Cobros
{
    [Key]
    public int CobroId { get; set; }
    public int DeudorId { get; set; }
    
    [Required]
    public DateTime Fecha { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio. ")]
    [Range(minimum: 0.1, maximum: 9999999999, ErrorMessage = "Ingrese un cantidad válida.")]
    public Decimal Monto { get; set; }


    [ForeignKey("DeudorId")]
    public ICollection<Deudores> Deudores { get; set; } = new List<Deudores>();
}
