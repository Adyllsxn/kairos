using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kairos.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_TipoEvento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TipoEvento", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tbl_TipoEvento",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Ensaio" },
                    { 2, "Evento Especial" },
                    { 3, "Reunião" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_TipoEvento");
        }
    }
}
