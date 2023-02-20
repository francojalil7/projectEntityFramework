using Microsoft.EntityFrameworkCore;
using projectef.Models;
namespace projectef;
public class TareasContext : DbContext
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Tarea> Tareas { get; set; }
    public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Categoria> categoriasInit = new List<Categoria>();
        categoriasInit.Add(new Categoria() { CategoriaId = Guid.Parse("482b1bd3-20a0-4ff5-be0e-bc198ef61e07"), Nombre = "Actividades pendientes", Peso = 20 });
        categoriasInit.Add(new Categoria() { CategoriaId = Guid.Parse("482b1bd3-20a0-4ff5-be0e-bc198ef61e02"), Nombre = "Actividades personales", Peso = 50 });

        modelBuilder.Entity<Categoria>(categoria =>
        {
            categoria.ToTable("Categoria");
            categoria.HasKey(p => p.CategoriaId);
            categoria.Property(p => p.Nombre).IsRequired().HasMaxLength(100);
            categoria.Property(p => p.Descripcion).IsRequired(false);
            categoria.Property(p => p.Peso);
            categoria.HasData(categoriasInit);
        });

        List<Tarea> tareasInit = new List<Tarea>();
        tareasInit.Add(new Tarea() { TareaId = Guid.Parse("482b1bd3-20a0-4ff5-be0e-bc198ef61e10"), CategoriaId = Guid.Parse("482b1bd3-20a0-4ff5-be0e-bc198ef61e07"), PrioridadTarea = Prioridad.Media, Titulo = "Pago de servicios publicos", FechaCreacion = DateTime.Now });
        tareasInit.Add(new Tarea() { TareaId = Guid.Parse("482b1bd3-20a0-4ff5-be0e-bc198ef61e13"), CategoriaId = Guid.Parse("482b1bd3-20a0-4ff5-be0e-bc198ef61e07"), PrioridadTarea = Prioridad.Media, Titulo = "Pago de servicios publicos", FechaCreacion = DateTime.Now });

        tareasInit.Add(new Tarea() { TareaId = Guid.Parse("482b1bd3-20a0-4ff5-be0e-bc198ef61e11"), CategoriaId = Guid.Parse("482b1bd3-20a0-4ff5-be0e-bc198ef61e02"), PrioridadTarea = Prioridad.Alta, Titulo = "Terminar curso .NET", FechaCreacion = DateTime.Now });


        modelBuilder.Entity<Tarea>(tarea =>
        {
            tarea.ToTable("Tarea");
            tarea.HasKey(t => t.TareaId);
            tarea.HasOne(t => t.Categoria).WithMany(t => t.Tareas).HasForeignKey(p => p.CategoriaId);
            tarea.Property(p => p.Titulo).IsRequired().HasMaxLength(100);
            tarea.Property(p => p.Descripcion).IsRequired(false);
            tarea.Property(p => p.PrioridadTarea);
            tarea.Property(p => p.FechaCreacion);
            tarea.Ignore(p => p.Resumen);
            tarea.Property(p => p.ShortDescription).HasMaxLength(50).IsRequired(false);
            tarea.HasData(tareasInit);
        });
    }
}