using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JcmSoft.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class IncluiNumeroOrdemServicoProjeto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "NumeroOSSequence",
                startValue: 2001L,
                incrementBy: 10,
                minValue: 2001L,
                maxValue: 999999L,
                cyclic: true);

            migrationBuilder.AddColumn<int>(
                name: "NumeroOrdemServico",
                table: "Projetos",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR NumeroOSSequence");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroOrdemServico",
                table: "Projetos");

            migrationBuilder.DropSequence(
                name: "NumeroOSSequence");
        }
    }
}
