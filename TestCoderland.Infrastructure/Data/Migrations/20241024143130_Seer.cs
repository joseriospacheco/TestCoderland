using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestCoderland.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MarcasAuto",
                table: "MarcasAuto");

            migrationBuilder.RenameTable(
                name: "MarcasAuto",
                newName: "marcas_de_autos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_marcas_de_autos",
                table: "marcas_de_autos",
                column: "Id");

            migrationBuilder.InsertData(
                table: "marcas_de_autos",
                columns: new[] { "Id", "Nombre", "PaisOrigen" },
                values: new object[,]
                {
                    { 1, "Toyota", "Japón" },
                    { 2, "Ford", "Estados Unidos" },
                    { 3, "Renault", "Francia" },
                    { 4, "Kia", "Corea del Sur" },
                    { 5, "Chevrolet", "Estados Unidos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_marcas_de_autos",
                table: "marcas_de_autos");

            migrationBuilder.DeleteData(
                table: "marcas_de_autos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "marcas_de_autos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "marcas_de_autos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "marcas_de_autos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "marcas_de_autos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameTable(
                name: "marcas_de_autos",
                newName: "MarcasAuto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MarcasAuto",
                table: "MarcasAuto",
                column: "Id");
        }
    }
}
