using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CV_Sajten.Migrations
{
    /// <inheritdoc />
    public partial class migration12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Cvs",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Losenord",
                table: "Anvandares",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Anvandares",
                keyColumn: "ID",
                keyValue: 1,
                column: "Losenord",
                value: "hej1");

            migrationBuilder.UpdateData(
                table: "Anvandares",
                keyColumn: "ID",
                keyValue: 21,
                column: "Losenord",
                value: "hej2");

            migrationBuilder.InsertData(
                table: "Cvs",
                columns: new[] { "Id", "AnvandareID", "Erfarenheter", "Kompetenser", "Utbildning" },
                values: new object[,]
                {
                    { 2, 21, "3 års erfarenhet som systemutvecklare på TechCorp", "C#, .NET, SQL, Azure", "Civilingenjör i Datateknik, KTH" },
                    { 3, 1, "3 års erfarenhet som systemutvecklare på TechCorp", "C#, .NET, SQL, Azure", "Civilingenjör i Datateknik, KTH" },
                    { 4, 1, "3 års erfarenhet som systemutvecklare på TechCorp", "C#, .NET, SQL, Azure", "Civilingenjör i Datateknik, KTH" },
                    { 5, 1, "3 års erfarenhet som systemutvecklare på TechCorp", "C#, .NET, SQL, Azure", "Civilingenjör i Datateknik, KTH" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cvs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cvs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cvs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cvs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Losenord",
                table: "Anvandares");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cvs",
                newName: "ID");
        }
    }
}
