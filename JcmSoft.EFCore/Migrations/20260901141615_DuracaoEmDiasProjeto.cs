using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JcmSoft.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class DuracaoEmDiasProjeto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DuracaoEmDias",
                table: "Projetos",
                type: "int",
                nullable: false,
                computedColumnSql: "DATEDIFF(day,DataInico,DataFim)",
                stored: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DuracaoEmDias",
                table: "Projetos");
        }
    }
}
