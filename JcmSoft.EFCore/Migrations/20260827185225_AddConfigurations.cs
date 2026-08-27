using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JcmSoft.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FuncionariosProjetos",
                columns: new[] { "FuncionarioId", "ProjetoId", "HorasTrabalhadas" },
                values: new object[,]
                {
                    { 1, 1, 80 },
                    { 1, 19, 100 },
                    { 2, 1, 60 },
                    { 3, 2, 90 },
                    { 3, 20, 55 },
                    { 4, 2, 70 },
                    { 5, 3, 100 },
                    { 5, 4, 30 },
                    { 6, 4, 100 },
                    { 7, 5, 100 },
                    { 8, 6, 100 },
                    { 8, 10, 25 },
                    { 9, 7, 100 },
                    { 10, 8, 100 },
                    { 11, 9, 40 },
                    { 12, 10, 100 },
                    { 12, 19, 35 },
                    { 13, 11, 100 },
                    { 14, 12, 70 },
                    { 15, 13, 35 },
                    { 16, 14, 80 },
                    { 17, 15, 100 },
                    { 18, 16, 100 },
                    { 19, 17, 50 },
                    { 20, 18, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 12, 19 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 13, 11 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 14, 12 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 15, 13 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 16, 14 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 17, 15 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 18, 16 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 19, 17 });

            migrationBuilder.DeleteData(
                table: "FuncionariosProjetos",
                keyColumns: new[] { "FuncionarioId", "ProjetoId" },
                keyValues: new object[] { 20, 18 });
        }
    }
}
