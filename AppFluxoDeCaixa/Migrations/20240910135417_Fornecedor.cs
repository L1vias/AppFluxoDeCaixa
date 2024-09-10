using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppFluxoDeCaixa.Migrations
{
    /// <inheritdoc />
    public partial class Fornecedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "1234Clientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_1234Clientes",
                table: "1234Clientes",
                column: "ClientesId");

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    FornecedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DataDeCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.FornecedorId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_1234Clientes",
                table: "1234Clientes");

            migrationBuilder.RenameTable(
                name: "1234Clientes",
                newName: "Clientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "ClientesId");
        }
    }
}
