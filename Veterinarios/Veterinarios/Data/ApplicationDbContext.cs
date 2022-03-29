using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Veterinarios.Models;

namespace Veterinarios.Data
{
    /// <summary>
    /// esta classe funciona comom a base de dados do nosso projecto
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // definir as 'tabelas'

        public DbSet<Animais> Animais { get; set; }
        public DbSet<Models.Veterinarios> Veterinarios { get; set; }
        public DbSet<Consultas> Consultas { get; set; }
        public DbSet<Donos> Donos { get; set; }
    }
}