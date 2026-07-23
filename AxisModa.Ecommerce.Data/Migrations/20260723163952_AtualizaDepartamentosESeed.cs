using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AxisModa.Ecommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaDepartamentosESeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Produtos",
                type: "varchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Subcategoria",
                table: "Produtos",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Ativo", "Categoria", "DataCriacao", "Descricao", "Estoque", "ImagemUrl", "Nome", "Preco", "Subcategoria" },
                values: new object[,]
                {
                    { new Guid("60762f4d-bc3f-4221-b306-e5f7ba2920e9"), true, "Feminino", new DateTime(2026, 7, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Vestido de seda premium fluido para ocasioes especiais.", 18, "https://unsplash.com", "Vestido Seda Midi", 349.90m, "Vestido" },
                    { new Guid("9f8c7bcf-6f68-459b-a7b8-a733370f2cb7"), true, "Masculino", new DateTime(2026, 7, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Camisa de linho respiravel com corte classico.", 25, "https://unsplash.com", "Camisa Linho Comfort", 189.90m, "Camisa" },
                    { new Guid("aeaaec9f-a407-4909-b6c9-a65f7356a263"), true, "Infantil", new DateTime(2026, 7, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Conjunto super confortavel de camiseta e shorts.", 40, "https://unsplash.com", "Conjunto Infantil Algodao", 99.90m, "Conjunto" },
                    { new Guid("bb98a8d4-4e0e-46db-bef6-56cc77ecf145"), true, "Feminino", new DateTime(2026, 7, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Blusa cropped de malha com toque macio.", 32, "https://unsplash.com", "Blusa Cropped Urban", 79.90m, "Blusa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("60762f4d-bc3f-4221-b306-e5f7ba2920e9"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("9f8c7bcf-6f68-459b-a7b8-a733370f2cb7"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("aeaaec9f-a407-4909-b6c9-a65f7356a263"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("bb98a8d4-4e0e-46db-bef6-56cc77ecf145"));

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Subcategoria",
                table: "Produtos");
        }
    }
}
