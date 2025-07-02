using Microsoft.EntityFrameworkCore;
using PHOTELAPP.Web.Data.Entities;

namespace PHOTELAPP.Web.Data
{
    public interface IApplicationDbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}