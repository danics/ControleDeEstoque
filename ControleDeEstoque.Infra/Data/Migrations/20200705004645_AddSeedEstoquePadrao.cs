using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeEstoque.Infra.Data.Migrations
{
    public partial class AddSeedEstoquePadrao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Estoques",
                columns: new[] { "Id", "Descricao" },
                values: new object[] { 1, "Estoque Padrao" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estoques",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
