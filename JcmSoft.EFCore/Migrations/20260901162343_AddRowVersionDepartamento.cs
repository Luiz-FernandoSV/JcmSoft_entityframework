using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JcmSoft.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddRowVersionDepartamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Departamentos",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Departamentos");
        }
    }
}
