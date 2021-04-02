using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Andre.App.ViewModels;

namespace Andre.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Andre.App.ViewModels.FornecedorViewModel> FornecedorViewModel { get; set; }
        public DbSet<Andre.App.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; }
    }
}
