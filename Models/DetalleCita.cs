using System.ComponentModel.DataAnnotations;

  namespace GlamApp.Models;

  public class DetalleCita
  {
      public int Id { get; set; }

      public int CitaId { get; set; }
      public Cita? Cita { get; set; }

      public int ServicioId { get; set; }
      public Servicio? Servicio { get; set; }

      [Range(0.01, 99999)]
      public decimal PrecioUnitario { get; set; }

      public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
  }