using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectef.Migrations
{
    /// <inheritdoc />
    public partial class InitialData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e10"),
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 22, 2, 23, 77, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e11"),
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 22, 2, 23, 77, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e13"),
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 22, 2, 23, 77, DateTimeKind.Local).AddTicks(9319));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e10"),
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 21, 56, 27, 16, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e11"),
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 21, 56, 27, 16, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("482b1bd3-20a0-4ff5-be0e-bc198ef61e13"),
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 21, 56, 27, 16, DateTimeKind.Local).AddTicks(7886));
        }
    }
}
