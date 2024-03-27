using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppUsuario.Models;

namespace WebAppUsuario.Data
{
    public class WebAppUsuarioContext : DbContext
    {
        public WebAppUsuarioContext (DbContextOptions<WebAppUsuarioContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppUsuario.Models.UsuarioModel> UsuarioModel { get; set; } = default!;

        public DbSet<WebAppUsuario.Models.CarroModel>? CarroModel { get; set; }
    }
}
