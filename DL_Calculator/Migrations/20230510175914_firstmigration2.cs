using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DL_Calculator.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dl_Values",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    over_left = table.Column<int>(type: "int", nullable: false),
                    wicket_lost = table.Column<int>(type: "int", nullable: false),
                    resources = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dl_Values", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dl_Values");
        }
    }
}
