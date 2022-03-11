using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_PW.Entidades;

namespace Projeto_PW
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> option):base(option)
        { }
        public DbSet<Usuario> USUARIOS { get; set; }
    }
}
