using System.ComponentModel.DataAnnotations;

  namespace GlamApp.Models;

  public class Cliente
  {
      public int Id { get; set; }

      [Required]
      [StringLength(100)]
      public string Nombre { get; set; } = string.Empty;

      [Required]
      [StringLength(100)]
      public string Apellido { get; set; } = string.Empty;

      [StringLength(20)]
      public string Telefono { get; set; } = string.Empty;

      [EmailAddress]
      [StringLength(150)]
      public string Email { get; set; } = string.Empty;

      public bool Activo { get; set; } = true;

      public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
  }