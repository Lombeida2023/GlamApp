using System.ComponentModel.DataAnnotations;

  namespace GlamApp.Models;

  public class Servicio
  {
      public int Id { get; set; }

      [Required]
      [StringLength(100)]
      public string Nombre { get; set; } = string.Empty;

      [StringLength(250)]
      public string Descripcion { get; set; } = string.Empty;

      [Range(0.01, 99999)]
      public decimal Precio { get; set; }

      public int DuracionMinutos { get; set; }

      public int CategoriaId { get; set; }
      public Categoria? Categoria { get; set; }

      public bool Activo { get; set; } = true;

      public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
  }