using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Sajten.Migrations
{
    /// <inheritdoc />
    public partial class Kayhan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Anvandares",
                columns: new[] { "ID", "BildAdress", "Email", "Namn", "isPrivat" },
                values: new object[] { 21, "https://example.com/images/erik.jpg", "erik.svensson@example.com", "Erik Svensson", false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Anvandares",
                keyColumn: "ID",
                keyValue: 21);
        }
    }
}
