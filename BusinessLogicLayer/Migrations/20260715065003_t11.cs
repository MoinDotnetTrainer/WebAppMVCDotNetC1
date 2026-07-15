using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessLogicLayer.Migrations
{
    /// <inheritdoc />
    public partial class t11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t1tbl_t1tbl_T2DataID",
                table: "t1tbl");

            migrationBuilder.DropIndex(
                name: "IX_t1tbl_T2DataID",
                table: "t1tbl");

            migrationBuilder.DropColumn(
                name: "T2DataID",
                table: "t1tbl");

            migrationBuilder.CreateIndex(
                name: "IX_t2tbl_T1ID",
                table: "t2tbl",
                column: "T1ID");

            migrationBuilder.AddForeignKey(
                name: "FK_t2tbl_t1tbl_T1ID",
                table: "t2tbl",
                column: "T1ID",
                principalTable: "t1tbl",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t2tbl_t1tbl_T1ID",
                table: "t2tbl");

            migrationBuilder.DropIndex(
                name: "IX_t2tbl_T1ID",
                table: "t2tbl");

            migrationBuilder.AddColumn<int>(
                name: "T2DataID",
                table: "t1tbl",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_t1tbl_T2DataID",
                table: "t1tbl",
                column: "T2DataID");

            migrationBuilder.AddForeignKey(
                name: "FK_t1tbl_t1tbl_T2DataID",
                table: "t1tbl",
                column: "T2DataID",
                principalTable: "t1tbl",
                principalColumn: "ID");
        }
    }
}
