// <auto-generated />
using Ecomerce_Profetional;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WooComerce.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210408145409_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ecomerce_Profetional.Models.CadastroViewModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("CadastroViewModel");
                });

            modelBuilder.Entity("Ecomerce_Profetional.Models.ItemPedidoViewModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<float>("PrecoUnitario")
                        .HasColumnType("real");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItemPedidoViewModel");
                });

            modelBuilder.Entity("Ecomerce_Profetional.Models.PedidoViewModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CadastroId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CadastroId");

                    b.ToTable("PedidoViewModel");
                });

            modelBuilder.Entity("Ecomerce_Profetional.Models.ProdutoViewModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Preco")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Ecomerce_Profetional.Models.ItemPedidoViewModel", b =>
                {
                    b.HasOne("Ecomerce_Profetional.Models.PedidoViewModel", "Pedido")
                        .WithMany("ItemPedido")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecomerce_Profetional.Models.ProdutoViewModel", "Produto")
                        .WithMany("ItemPedido")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Ecomerce_Profetional.Models.PedidoViewModel", b =>
                {
                    b.HasOne("Ecomerce_Profetional.Models.CadastroViewModel", "Cadastro")
                        .WithMany("Pedidos")
                        .HasForeignKey("CadastroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cadastro");
                });

            modelBuilder.Entity("Ecomerce_Profetional.Models.CadastroViewModel", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Ecomerce_Profetional.Models.PedidoViewModel", b =>
                {
                    b.Navigation("ItemPedido");
                });

            modelBuilder.Entity("Ecomerce_Profetional.Models.ProdutoViewModel", b =>
                {
                    b.Navigation("ItemPedido");
                });
#pragma warning restore 612, 618
        }
    }
}
