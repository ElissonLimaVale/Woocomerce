using Microsoft.EntityFrameworkCore.Migrations;

namespace WooComerce.Migrations
{
    public partial class Relational : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedidoViewModel_PedidoViewModel_PedidoId",
                table: "ItemPedidoViewModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedidoViewModel_Produto_ProdutoId",
                table: "ItemPedidoViewModel");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoViewModel_CadastroViewModel_CadastroId",
                table: "PedidoViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoViewModel",
                table: "PedidoViewModel");

            migrationBuilder.DropIndex(
                name: "IX_PedidoViewModel_CadastroId",
                table: "PedidoViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemPedidoViewModel",
                table: "ItemPedidoViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CadastroViewModel",
                table: "CadastroViewModel");

            migrationBuilder.RenameTable(
                name: "PedidoViewModel",
                newName: "Pedido");

            migrationBuilder.RenameTable(
                name: "ItemPedidoViewModel",
                newName: "ItemPedido");

            migrationBuilder.RenameTable(
                name: "CadastroViewModel",
                newName: "Cadastro");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPedidoViewModel_ProdutoId",
                table: "ItemPedido",
                newName: "IX_ItemPedido_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPedidoViewModel_PedidoId",
                table: "ItemPedido",
                newName: "IX_ItemPedido_PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemPedido",
                table: "ItemPedido",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cadastro",
                table: "Cadastro",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_CadastroId",
                table: "Pedido",
                column: "CadastroId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoId",
                table: "ItemPedido",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedido_Produto_ProdutoId",
                table: "ItemPedido",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cadastro_CadastroId",
                table: "Pedido",
                column: "CadastroId",
                principalTable: "Cadastro",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoId",
                table: "ItemPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedido_Produto_ProdutoId",
                table: "ItemPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cadastro_CadastroId",
                table: "Pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_CadastroId",
                table: "Pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemPedido",
                table: "ItemPedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cadastro",
                table: "Cadastro");

            migrationBuilder.RenameTable(
                name: "Pedido",
                newName: "PedidoViewModel");

            migrationBuilder.RenameTable(
                name: "ItemPedido",
                newName: "ItemPedidoViewModel");

            migrationBuilder.RenameTable(
                name: "Cadastro",
                newName: "CadastroViewModel");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPedido_ProdutoId",
                table: "ItemPedidoViewModel",
                newName: "IX_ItemPedidoViewModel_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPedido_PedidoId",
                table: "ItemPedidoViewModel",
                newName: "IX_ItemPedidoViewModel_PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoViewModel",
                table: "PedidoViewModel",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemPedidoViewModel",
                table: "ItemPedidoViewModel",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CadastroViewModel",
                table: "CadastroViewModel",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoViewModel_CadastroId",
                table: "PedidoViewModel",
                column: "CadastroId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedidoViewModel_PedidoViewModel_PedidoId",
                table: "ItemPedidoViewModel",
                column: "PedidoId",
                principalTable: "PedidoViewModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedidoViewModel_Produto_ProdutoId",
                table: "ItemPedidoViewModel",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoViewModel_CadastroViewModel_CadastroId",
                table: "PedidoViewModel",
                column: "CadastroId",
                principalTable: "CadastroViewModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
