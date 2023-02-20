using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace projectef.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Tarea",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e02"), null, "Actividades personales", 50 },
                    { new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e07"), null, "Actividades pendientes", 20 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "ShortDescription", "Titulo" },
                values: new object[,]
                {
                    { new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e10"), new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e07"), null, new DateTime(2023, 2, 16, 21, 56, 27, 16, DateTimeKind.Local).AddTicks(7871), 1, null, "Pago de servicios publicos" },
                    { new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e11"), new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e02"), null, new DateTime(2023, 2, 16, 21, 56, 27, 16, DateTimeKind.Local).AddTicks(7889), 2, null, "Terminar curso .NET" },
                    { new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e13"), new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e07"), null, new DateTime(2023, 2, 16, 21, 56, 27, 16, DateTimeKind.Local).AddTicks(7886), 1, null, "Pago de servicios publicos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e10"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e11"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e13"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e02"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e07"));

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Tarea",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
