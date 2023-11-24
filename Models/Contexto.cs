using Microsoft.EntityFrameworkCore;

namespace SabinLab.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        //public DbSet<Pessoa> Pessoa { get; set; }
        //public DbSet<Profissional> Profissional { get; set; }
        //public DbSet<Cargo> Cargo { get; set; }
        //public DbSet<Estado> Estado { get; set; }
        //public DbSet<Cidade> Cidade { get; set; }
        //public DbSet<Resultado> Resultado { get; set; }
        //public DbSet<Exame> Exame { get; set; }

    }
}
