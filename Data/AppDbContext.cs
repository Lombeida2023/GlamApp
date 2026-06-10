using GlamApp.Models;                                                                                                                                        
  using Microsoft.EntityFrameworkCore;                                                                                                                       

  namespace GlamApp.Data;

  public class AppDbContext : DbContext
  {
      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
      {
      }

      public DbSet<Categoria> Categorias { get; set; }
      public DbSet<Servicio> Servicios { get; set; }
      public DbSet<Empleado> Empleados { get; set; }
      public DbSet<Cliente> Clientes { get; set; }
      public DbSet<Cita> Citas { get; set; }
      public DbSet<DetalleCita> DetalleCitas { get; set; }
  }