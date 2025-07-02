using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PHOTELAPP.Web.Data.Entities;

namespace PHOTELAPP.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        private readonly IConfiguration config;

        public ApplicationDbContext(IConfiguration config)
        {
            this.config = config;
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.IdCliente)
                .WithMany()
                .HasForeignKey(r => r.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.IDHabitacion)
                .WithMany()
                .HasForeignKey(r => r.HabitacionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}


