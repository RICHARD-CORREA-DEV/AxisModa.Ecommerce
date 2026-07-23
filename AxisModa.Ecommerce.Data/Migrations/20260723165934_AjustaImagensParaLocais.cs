using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AxisModa.Ecommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjustaImagensParaLocais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("60762f4d-bc3f-4221-b306-e5f7ba2920e9"),
                column: "ImagemUrl",
                value: "/uploads/produtos/vestido.jpg");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("9f8c7bcf-6f68-459b-a7b8-a733370f2cb7"),
                column: "ImagemUrl",
                value: "/uploads/produtos/camisa.jpg");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("aeaaec9f-a407-4909-b6c9-a65f7356a263"),
                column: "ImagemUrl",
                value: "/uploads/produtos/infantil.jpg");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("bb98a8d4-4e0e-46db-bef6-56cc77ecf145"),
                column: "ImagemUrl",
                value: "/uploads/produtos/blusa.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("60762f4d-bc3f-4221-b306-e5f7ba2920e9"),
                column: "ImagemUrl",
                value: "https://unsplash.com");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("9f8c7bcf-6f68-459b-a7b8-a733370f2cb7"),
                column: "ImagemUrl",
                value: "https://unsplash.com");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("aeaaec9f-a407-4909-b6c9-a65f7356a263"),
                column: "ImagemUrl",
                value: "https://unsplash.com");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("bb98a8d4-4e0e-46db-bef6-56cc77ecf145"),
                column: "ImagemUrl",
                value: "https://unsplash.com");
        }
    }
}
