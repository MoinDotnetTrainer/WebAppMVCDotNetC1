using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessLogicLayer.Migrations
{
    /// <inheritdoc />
    public partial class t1111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t3tbl",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t3tbl", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "t4tbl",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<int>(type: "int", nullable: false),
                    T3ID = table.Column<int>(type: "int", nullable: false),
                    abovetable = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t4tbl", x => x.ID);
                    table.ForeignKey(
                        name: "FK_t4tbl_t3tbl_abovetable",
                        column: x => x.abovetable,
                        principalTable: "t3tbl",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_t4tbl_abovetable",
                table: "t4tbl",
                column: "abovetable",
                unique: true,
                filter: "[abovetable] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t4tbl");

            migrationBuilder.DropTable(
                name: "t3tbl");
        }
    }
}
