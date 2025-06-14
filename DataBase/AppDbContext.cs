using Encurtador.Models.Usuario;
using Microsoft.EntityFrameworkCore;

namespace Encurtador.DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
