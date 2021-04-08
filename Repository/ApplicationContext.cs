using Ecomerce_Profetional.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce_Profetional
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<ProdutoViewModel> Produto { get; set; }
        public DbSet<PedidoViewModel> Pedido { get; set; }
        public DbSet<ItemPedidoViewModel> ItemPedido { get; set; }
        public DbSet<CadastroViewModel> Cadastro { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ProdutoViewModel>().HasKey(x => x.id);

            builder.Entity<PedidoViewModel>().HasKey(x => x.id);
            builder.Entity<PedidoViewModel>().HasMany(x => x.ItemPedido).WithOne(x => x.Pedido);
            builder.Entity<PedidoViewModel>().HasOne(x => x.Cadastro).WithOne(x => x.Pedido).IsRequired();

            builder.Entity<ItemPedidoViewModel>().HasKey(x => x.id);
            builder.Entity<ItemPedidoViewModel>().HasOne(x => x.Pedido);
            builder.Entity<ItemPedidoViewModel>().HasOne(x => x.Produto);

            builder.Entity<CadastroViewModel>().HasKey(x => x.id);
            builder.Entity<CadastroViewModel>().HasOne(x => x.Pedido);
        }
    }
}
