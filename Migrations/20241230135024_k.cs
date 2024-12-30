using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Sajten.Migrations
{
    /// <inheritdoc />
    public partial class k : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cvs",
                keyColumn: "ID",
                keyValue: 1,
                column: "AnvandareID",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cvs",
                keyColumn: "ID",
                keyValue: 1,
                column: "AnvandareID",
                value: 1001);
        }
    }
}
