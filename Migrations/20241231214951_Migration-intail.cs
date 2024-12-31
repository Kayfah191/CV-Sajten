using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CV_Sajten.Migrations
{
    /// <inheritdoc />
    public partial class Migrationintail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anvandares",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPrivat = table.Column<bool>(type: "bit", nullable: false),
                    BildAdress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anvandares", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cvs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kompetenser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Utbildning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Erfarenheter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnvandareID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cvs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cvs_Anvandares_AnvandareID",
                        column: x => x.AnvandareID,
                        principalTable: "Anvandares",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Anvandares",
                columns: new[] { "ID", "BildAdress", "Email", "Namn", "isPrivat" },
                values: new object[,]
                {
                    { 1, "https://example.com/images/anna.jpg", "anna.andersson@example.com", "Anna Andersson", true },
                    { 21, "https://example.com/images/erik.jpg", "erik.svensson@example.com", "Erik Svensson", false }
                });

            migrationBuilder.InsertData(
                table: "Cvs",
                columns: new[] { "ID", "AnvandareID", "Erfarenheter", "Kompetenser", "Utbildning" },
                values: new object[] { 1, 1, "3 års erfarenhet som systemutvecklare på TechCorp", "C#, .NET, SQL, Azure", "Civilingenjör i Datateknik, KTH" });

            migrationBuilder.CreateIndex(
                name: "IX_Cvs_AnvandareID",
                table: "Cvs",
                column: "AnvandareID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cvs");

            migrationBuilder.DropTable(
                name: "Anvandares");
        }
    }
}
