using Microsoft.EntityFrameworkCore;
using MistressObedience.Models;

namespace MistressObedience.Data
{
    public class ServantContext : DbContext
    {
        public ServantContext(DbContextOptions<ServantContext> options) : base(options) { }
        
        public DbSet<ServantModel> Servants { get; set; }
    }
}
