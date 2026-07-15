using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessLogicLayer.Migrations
{
    /// <inheritdoc />
    public partial class t1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t1tbl",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    T2DataID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t1tbl", x => x.ID);
                    table.ForeignKey(
                        name: "FK_t1tbl_t1tbl_T2DataID",
                        column: x => x.T2DataID,
                        principalTable: "t1tbl",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "t2tbl",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<int>(type: "int", nullable: false),
                    T1ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t2tbl", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t1tbl_T2DataID",
                table: "t1tbl",
                column: "T2DataID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t1tbl");

            migrationBuilder.DropTable(
                name: "t2tbl");
        }
    }
}
