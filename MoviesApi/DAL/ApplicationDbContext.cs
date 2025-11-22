using Microsoft.EntityFrameworkCore;
using MoviesApi.DAL.Models;

namespace MoviesApi.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Seccion para crear los DbSet de las entidades o modelos
        public DbSet<Category> Categories { get; set; }
    }
}
