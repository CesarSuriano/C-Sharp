using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetMVC5.Models;
using System.Data.Entity;

namespace AspNetMVC5.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Asp_Net_MVC_CS") { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
    }
}