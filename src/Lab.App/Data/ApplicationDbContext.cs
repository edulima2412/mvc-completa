using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lab.App.ViewModels;

namespace Lab.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Lab.App.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; }
        public DbSet<Lab.App.ViewModels.EnderecoViewModel> EnderecoViewModel { get; set; }
    }
}
