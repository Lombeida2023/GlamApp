using System.ComponentModel.DataAnnotations;

  namespace GlamApp.Models;

  public class Cita
  {
      public int Id { get; set; }

      public int ClienteId { get; set; }
      public Cliente? Cliente { get; set; }

      public int EmpleadoId { get; set; }
      public Empleado? Empleado { get; set; }

      public DateTime FechaCita { get; set; }

      [StringLength(50)]
      public string Estado { get; set; } = "Pendiente";

      [Range(0, 99999)]
      public decimal Total { get; set; }

      public bool Activo { get; set; } = true;

      public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
  }