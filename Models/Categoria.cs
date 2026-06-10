using System.ComponentModel.DataAnnotations;

  namespace GlamApp.Models;

  public class Categoria
  {
      public int Id { get; set; }

      [Required]
      [StringLength(100)]
      public string Nombre { get; set; } = string.Empty;

      public bool Activo { get; set; } = true;

      public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

      public ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();
  }