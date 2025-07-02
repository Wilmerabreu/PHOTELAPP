using Microsoft.EntityFrameworkCore;
using PHOTELAPP.Web.Data;
using PHOTELAPP.Web.Data.Entities;

namespace PHOTELAPP.Web.Services
{
    public class ReservaServicio
    {
        private readonly ApplicationDbContext _context;
        public ReservaServicio(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Reserva>> ObtenerReservasAsync()
        { 
            return await _context.Reservas.ToListAsync();
        }
        public async Task<Reserva> ObtenerReservaPorIdAsync(int id)
        {
            return await _context.Reservas.FirstOrDefaultAsync(r => r.Id == id);
        }
        public async Task<Reserva> CrearReservaAsync(Reserva reserva)
        {
            _context.Reservas.Add(reserva);
            await _context.SaveChangesAsync();
            return reserva;
        }
        public async Task<Reserva> ActualizarReservaAsync(Reserva reserva)
        {
            _context.Reservas.Update(reserva);
            await _context.SaveChangesAsync();
            return reserva;
        }
    }
}
