using Clases_KioPlus.Models;
using Microsoft.EntityFrameworkCore;

namespace Clases_KioPlus.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVentas { get; set; }
        public DbSet<CuentaCorrienteCliente> CuentasCorrientesClientes { get; set; }
        public DbSet<ProductoProveedor> ProductoProveedores { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<Caja> Cajas { get; set; }
        public DbSet<CompraProveedor> Compras { get; set; }
        public DbSet<DetalleCompra> DetallesCompras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Mantiene la conexión ya configurada cuando no se inyectan opciones (ej. herramientas EF).
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=localhost;Database=KioPlusDB;Trusted_Connection=True;TrustServerCertificate=True;"
                );
            }
        }
    }
}
