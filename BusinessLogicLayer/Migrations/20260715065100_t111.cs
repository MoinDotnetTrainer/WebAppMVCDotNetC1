using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessLogicLayer.Migrations
{
    /// <inheritdoc />
    public partial class t111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_t2tbl_T1ID",
                table: "t2tbl");

            migrationBuilder.CreateIndex(
                name: "IX_t2tbl_T1ID",
                table: "t2tbl",
                column: "T1ID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_t2tbl_T1ID",
                table: "t2tbl");

            migrationBuilder.CreateIndex(
                name: "IX_t2tbl_T1ID",
                table: "t2tbl",
                column: "T1ID");
        }
    }
}
